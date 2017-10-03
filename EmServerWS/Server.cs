using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Net;
using System.Net.WebSockets;
using System.Diagnostics;

// For Regex
using System.Text.RegularExpressions;

// For QR
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace EmServerWS
{
    public class Server
    {
        public Server(int _pin, string _ip, Bitmap _qr, int _port = 80)
        {
            _client = new List<WebSocket>();
            pin = _pin;
            ip = _ip;
            QR = _qr;
            port = _port;

            Connections = new Detectable<int>();
            LatestLog = new Detectable<string>("");
        }

        public async void Start()
        {
            var httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://*:" + port + "/");
            httpListener.Start();

            while (true)
            {
                /// 接続待機
                var listenerContext = await httpListener.GetContextAsync();
                var req = listenerContext.Request;
                var res = listenerContext.Response;

                if (req.RawUrl == "/ws" && req.IsWebSocketRequest)
                {
                    /// httpのハンドシェイクがWebSocketならWebSocket接続開始
                    ProcessWebSocket(listenerContext);
                }
                else
                {
                    /// httpレスポンスを返す
                    ProcessHttp(req, res);
                }
            }

        }

        public Detectable<int> Connections { get; set; } // 接続数
        public Detectable<string> LatestLog { get; set; } // 最新のログ

        private void WriteLog(string _log)
        {
            LatestLog.Value = _log;
        }

        private int pin { get; set; }
        private int port { get; set; }
        private string ip { get; set; }
        private Bitmap QR;

        private List<WebSocket> _client { get; set; }
        private WebSocket performer = null;
        private IPAddress _performer_ip = null;
        private WebSocket EmServer = null;
        private IPAddress _emserver_ip = null;

        private readonly string docRoot = Environment.CurrentDirectory + @"\html\";

        private async void ProcessWebSocket(HttpListenerContext listenerContext)
        {
            var remoteIP = listenerContext.Request.RemoteEndPoint.Address;

            WriteLog(string.Format("**WS** [{0}] New Session : {1}", DateTime.Now.ToString(), remoteIP.ToString()));

            /// WebSocketの接続完了を待機してWebSocketオブジェクトを取得する
            var ws = (await listenerContext.AcceptWebSocketAsync(subProtocol: null)).WebSocket;

            /// 新規クライアントを追加
            _client.Add(ws);
            Connections.Value = _client.Count;

            if (_performer_ip != null && _performer_ip.ToString() == remoteIP.ToString())
            {
                performer = ws;
                Debug.WriteLine("Performer client connected.");
            }
            else if (_emserver_ip != null && (_emserver_ip.ToString() == remoteIP.ToString() || IPAddress.IsLoopback(remoteIP)) )
            {
                EmServer = ws;
                Debug.WriteLine("EmServer connected.");

                // IPアドレスの通知
                var ip_notice = "SERV\nIP\n" + ip + "\n";
                await EmServer.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(ip_notice)),
                                         WebSocketMessageType.Text,
                                         true,
                                         System.Threading.CancellationToken.None);

                // QRの送信
                var img = new byte[QR.Width * QR.Height * 3];
                var bits = QR.LockBits(new Rectangle(0, 0, QR.Width, QR.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
                Marshal.Copy(bits.Scan0, img, 0, img.Length);
                QR.UnlockBits(bits);

                await EmServer.SendAsync(new ArraySegment<byte>(img),
                                         WebSocketMessageType.Binary,
                                         true,
                                         System.Threading.CancellationToken.None);

            }
                
            /// WebSocketの送受信ループ
            while (ws.State == WebSocketState.Open)
            {
                try
                {
                    var buff = new ArraySegment<byte>(new byte[1024]);

                    /// 受信待機
                    var ret = await ws.ReceiveAsync(buff, System.Threading.CancellationToken.None);

                    /// テキスト
                    if (ret.MessageType == WebSocketMessageType.Text)
                    {
                        var rcv = buff.Take(ret.Count).ToArray();
                        var _msg = Encoding.UTF8.GetString(rcv);
                        var msg = _msg.Split();

                        WriteLog(string.Format("**WS** [{0}] Received : {1}", DateTime.Now.ToString(), remoteIP.ToString()));
                        WriteLog(string.Format("**WS** Message = {0}", _msg));


                        switch (msg[0])
                        {
                            case "PERFORMER":
                                if (performer != null)
                                {
                                    await performer.SendAsync(new ArraySegment<byte>(rcv),
                                        WebSocketMessageType.Text,
                                        true,
                                        System.Threading.CancellationToken.None);

                                }
                                break;

                            case "SERV":
                                // 演技終了
                                if (msg[1] == "ENDPERFORM")
                                {
                                    // 演技終了の通知をブロードキャスト
                                    Parallel.ForEach(_client.Where(c => (c != ws)),
                                        p => p.SendAsync(new ArraySegment<byte>(rcv),
                                        WebSocketMessageType.Text,
                                        true,
                                        System.Threading.CancellationToken.None));

                                    // EmServer側で切断判定になってしまうのでウェイトを入れる
                                    System.Threading.Thread.Sleep(2 * 1000);

                                    if (msg[2] == "DOSHARE" && IPAddress.IsLoopback(_emserver_ip))
                                    {
                                        // 共有プログラムの起動
                                        if (File.Exists(Environment.CurrentDirectory + @"\EmShare\EmShare.exe"))
                                        {
                                            var ps = new System.Diagnostics.Process();
                                            ps.StartInfo.FileName = Environment.CurrentDirectory + @"\EmShare\EmShare.exe";
                                            ps.Start();
                                        }
                                        
                                    }

                                    Environment.Exit(0);

                                }

                                await EmServer.SendAsync(new ArraySegment<byte>(rcv),
                                    WebSocketMessageType.Text,
                                    true,
                                    System.Threading.CancellationToken.None);

                                break;

                            case "CLIENT":
                                /// 各クライアントへ配信
                                /// (自分自身でなく、パフォーマーでなく、かつUnityサーバでない時に配信)
                                Parallel.ForEach(_client.Where(c => (c != ws && (performer == null || performer != ws) && c != EmServer)),
                                    p => p.SendAsync(new ArraySegment<byte>(rcv),
                                    WebSocketMessageType.Text,
                                    true,
                                    System.Threading.CancellationToken.None));
                                break;

                            default:
                                throw new ArgumentException("WebSocketの宛先が正しくありません。");
                        }
                        

                    }
                    else if (ret.MessageType == WebSocketMessageType.Close) /// クローズ
                    {
                        WriteLog(string.Format("**WS** [{0}] Session Close : {1}", DateTime.Now.ToString(), remoteIP.ToString()));
                        break;
                    }
                }
                catch (Exception ex)
                {
                    /// 例外 クライアントが異常終了
                    WriteLog(string.Format("**WS** [{0}] Session Abort : {1}", DateTime.Now.ToString(), remoteIP.ToString()));
                    Debug.WriteLine(ex);
                    break;
                }
            }

            /// クライアントを除外する
            _client.Remove(ws);
            Connections.Value = _client.Count;

            if (ws == performer)　performer = null;

            // サーバの異常終了を検知
            if (ws == EmServer)
            {
                // 演技終了の通知をブロードキャスト
                var _msg = "ENDPERFORM";
                var msg = Encoding.UTF8.GetBytes(_msg);
                Parallel.ForEach(_client.Where(c => c != ws),
                    p => p.SendAsync(new ArraySegment<byte>(msg),
                    WebSocketMessageType.Text,
                    true,
                    System.Threading.CancellationToken.None));

                Environment.Exit(0);

            }

            ws.Dispose();
        }

        private async void ProcessHttp(HttpListenerRequest req, HttpListenerResponse res)
        {
            string urlPath = req.RawUrl; // URL
            bool isFileReq = false;
            string msg = "";

            WriteLog("--Web-- " + urlPath + " from " + req.RemoteEndPoint.Address);

            switch (urlPath)
            {
                case "/":
                    urlPath = "/index.html";
                    isFileReq = true;
                    break;

                case "/check":
                    /// サーバ起動チェック
                    if (_performer_ip != null && req.RemoteEndPoint.Address.ToString() == _performer_ip.ToString())
                    {
                        // すでに認証済み
                        msg = "authenticated";
                    }
                    else
                    {
                        msg = "ok";
                    }
                    break;

                case "/pin":
                    /// PINコードチェック
                    // Requestからpinを取得
                    string req_pin;
                    using (var reader = new StreamReader(req.InputStream, req.ContentEncoding))
                    {
                        req_pin = reader.ReadToEnd();
                    }

                    // 数字部分のみ抽出
                    var re = new Regex(@"[^0-9]");
                    req_pin = re.Replace(req_pin, "");

                    // チェック
                    int req_pin_int;
                    if (performer == null && int.TryParse(req_pin, out req_pin_int) && req_pin_int == pin)
                    {
                        _performer_ip = req.RemoteEndPoint.Address;
                        Debug.WriteLine("Performer IP : " + _performer_ip);
                        msg = "ok";
                    }
                    else
                    {
                        msg = "ng";
                    }

                    break;

                case "/emserver":
                    _emserver_ip = req.RemoteEndPoint.Address;
                    msg = "ok";

                    break;

                default:
                    isFileReq = true;
                    break;
            }

            if (isFileReq)
            {
                // 実際のローカルファイルパス
                string path = docRoot + urlPath.Replace("/", "\\");

                // ファイル内容を出力
                try
                {
                    res.StatusCode = 200;
                    byte[] content = File.ReadAllBytes(path);
                    await res.OutputStream.WriteAsync(content, 0, content.Length);
                }
                catch (Exception ex)
                {
                    msg = "<html><head><meta charset=\"UTF-8\"></head><body>Emotionic<br>404 Not Found<br>Path : " + urlPath + "<br>" + ex.Message + "</body></html>";

                    res.StatusCode = 404;
                    byte[] content = Encoding.UTF8.GetBytes(msg);
                    await res.OutputStream.WriteAsync(content, 0, content.Length);
                }
            }
            else
            {
                res.StatusCode = 200;
                byte[] content = Encoding.UTF8.GetBytes(msg);
                await res.OutputStream.WriteAsync(content, 0, content.Length);

            }

            res.Close();

        }

    }

}
