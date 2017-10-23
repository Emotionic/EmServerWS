using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

using ZXing;
using ZXing.QrCode;
using System.Text;

namespace EmServerWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // ステータスランプ画像の生成
            lamps = new List<Bitmap>();

            // Red
            lamps.Add(new Bitmap(20, 20));
            var g = Graphics.FromImage(lamps[0]);
            g.FillRectangle(Brushes.Red, g.VisibleClipBounds);
            g.Dispose();

            // Green
            lamps.Add(new Bitmap(20, 20));
            g = Graphics.FromImage(lamps[1]);
            g.FillRectangle(Brushes.Lime, g.VisibleClipBounds);
            g.Dispose();

            // ランプに画像を設定
            picBox_ServLamp.Image = lamps[0];
            picBox_KJLamp.Image = lamps[0];

            // IPアドレスを取得
            var ip = GetIP();
            if (ip == null)
            {
                lab_IP.ForeColor = Color.Red;
                lab_IP.Font = new Font("メイリオ", 12, FontStyle.Bold);
                lab_IP.Text = "<<< IPアドレスを取得できませんでした >>>";
            }
            else
            {
                lab_IP.Text = ip.ToString();
            }

            // PINコードを生成
            var rnd = new Random(Environment.TickCount + 810);
            int pin = 0;
            for (var i = 0; i < 4; i++)
            {
                pin *= 10;
                pin += rnd.Next(0, 10);
            }

            if (File.Exists(_fixedPinFilename))
            {
                using (var sr = new StreamReader(_fixedPinFilename, Encoding.UTF8))
                {
                    var _pin = sr.ReadToEnd();
                    pin = int.Parse(_pin);
                }
            }

            lab_Pin.Text = pin.ToString("0000");

            // QRコードの生成
            QR_Performer = CreateQR(true, lab_IP.Text, lab_Pin.Text);
            QR_Audience = CreateQR(false, lab_IP.Text, lab_Pin.Text);
            picBox_QR_P.Image = QR_Performer;
            picBox_QR_A.Image = QR_Audience;

            // サーバ初期化
            _server = new Server(pin, lab_IP.Text, QR_Audience);

            // イベント登録
            _server.LatestLog.mChanged += value =>
            {
                tb_Log.SelectionStart = 0;
                tb_Log.SelectionFont = new Font("メイリオ", 9, FontStyle.Regular);
                tb_Log.SelectionColor = Color.Black;
                tb_Log.SelectedText = $"[{DateTime.Now}] {value}\n";
            };

            _server.TotalConnections.mChanged += value =>
            {
                lab_WSCount.Text = value.ToString();
            };

            _server.ClientConnections.mChanged += value =>
            {
                lab_ClientCount.Text = value.ToString();
            };

            _server.EmServerConnected.mChanged += value =>
            {
                picBox_ServLamp.Image = value ? lamps[1] : lamps[0];
            };

            _server.EmKinectJoinConnected.mChanged += value =>
            {
                picBox_KJLamp.Image = value ? lamps[1] : lamps[0];
            };

            // サーバの起動
            _server.Start();

            // EmServer(Unity)の起動
            if (File.Exists(Environment.CurrentDirectory + @"\EmServer\EmServer.exe"))
            {
                var ps = new System.Diagnostics.Process();
                ps.StartInfo.FileName = Environment.CurrentDirectory + @"\EmServer\EmServer.exe";
                ps.Start();
            } else
            {
                tb_Log.SelectionFont = new Font("メイリオ", 9, FontStyle.Bold | FontStyle.Underline);
                tb_Log.SelectionColor = Color.Red;
                tb_Log.SelectedText = "EmServer(Unity)を検出できませんでした。\nサーバー単体で起動します。";
            }

        }

        private Server _server;
        private Bitmap QR_Performer;
        private Bitmap QR_Audience;

        private List<Bitmap> lamps; // 0: Red, 1: Green

        private string _fixedPinFilename = Environment.CurrentDirectory + @"\.fixed_pin";

        private int _debug_count = 0;

        private IPAddress GetIP()
        {
            var ip = IPAddress.None;
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();

            foreach (var adapter in interfaces)
            {
                if (adapter.OperationalStatus != OperationalStatus.Up)
                {
                    continue;
                }

                var properties = adapter.GetIPProperties();

                foreach (var unicast in properties.UnicastAddresses)
                {
                    if (unicast.Address.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(unicast.Address))
                    {
                        // 仮想マシンのアダプター等を除外する
                        if (adapter.Description.Contains("Virtual")) continue;
                        return unicast.Address;
                    }
                }
            }

            return null;
        }

        private Bitmap CreateQR(bool _isPerformer, string _ip, string _pin)
        {
            var qrdata = "{";
            qrdata += "\"isPerformer\" : " + (_isPerformer ? "true" : "false") + ", ";
            qrdata += "\"IP\" : \"" + lab_IP.Text + "\", ";
            qrdata += "\"PIN\" : \"" + (_isPerformer ? lab_Pin.Text : "") + "\" ";
            qrdata += "}";

            var writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new QrCodeEncodingOptions
                {
                    Width = 256,
                    Height = 256
                }
            };

            return writer.Write(qrdata);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlg = MessageBox.Show("EmServerWSを終了しますか？\n(EmServer(Unity)も同時終了します。)", "終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                //EmServerのプロセスを終了
                var ps = System.Diagnostics.Process.GetProcessesByName("EmServer");

                foreach (var p in ps)
                {
                    p.CloseMainWindow();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnClsLog_Click(object sender, EventArgs e)
        {
            tb_Log.Clear();
        }

        private void btnToggleTopMost_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            btnToggleTopMost.Text = this.TopMost ? "最前面解除" : "最前面にする";
        }

        private void picboc_Emotionic_Click(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                _debug_count++;
                if (_debug_count >= 3)
                {
                    var qrdiag = new QRDiag();
                    qrdiag.ShowDialog();

                    _debug_count = 0;
                }
            }
        }
    }
}
