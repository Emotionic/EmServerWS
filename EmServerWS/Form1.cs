using System;
using System.Drawing;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

using ZXing;
using ZXing.QrCode;

namespace EmServerWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Get IP
            lab_IP.Text = GetIP().ToString();

            // Generate pin
            var rnd = new Random(Environment.TickCount + 810);
            int pin = 0;
            for (var i = 0; i < 4; i++)
            {
                pin *= 10;
                pin += rnd.Next(0, 10);
            }
            lab_Pin.Text = pin.ToString("0000");

            // Create 
            QR_Performer = CreateQR(true, lab_IP.Text, lab_Pin.Text);
            QR_Audience = CreateQR(false, lab_IP.Text, lab_Pin.Text);
            picBox_QR.Image = QR_Performer;

            // Start server
            _server = new Server(pin, QR_Audience);

            _server.LatestLog.mChanged += value =>
            {
                tb_Log.Text = $"[{DateTime.Now}] {value}" + Environment.NewLine + tb_Log.Text;
            };

            _server.Connections.mChanged += value =>
            {
                lab_WSCount.Text = "接続数：" + value;
            };

            _server.Start();

        }

        private Server _server;
        private Bitmap QR_Performer;
        private Bitmap QR_Audience;

        private IPAddress GetIP()
        {
            var ip = IPAddress.None;
            var interfaces = NetworkInterface.GetAllNetworkInterfaces();
            var hit = false;

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
                        // IPv4アドレス
                        ip = unicast.Address;
                        if (adapter.Name.Contains("イーサネット") || adapter.Name.Contains("ワイヤレス"))
                        {
                            hit = true;
                            break;
                        }
                    }
                }

                if (hit) break;
            }

            return ip;
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
            var dlg = MessageBox.Show("Emotionic Server WSを終了しますか？\n(Emotionic Server Unityも同時終了します。)", "終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                //EmServerのプロセスを取得
                var ps = System.Diagnostics.Process.GetProcessesByName("Emotionic");

                foreach (var p in ps)
                {
                    p.CloseMainWindow();
                    p.WaitForExit(10000);
                    if (!p.HasExited)
                    {
                        MessageBox.Show("Unityが終了しませんでした。\n手動でUnityを終了してください。", "終了", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void check_AudienceQR_CheckedChanged(object sender, EventArgs e)
        {
            if (check_AudienceQR.Checked)
            {
                picBox_QR.Image = QR_Audience;
            } else
            {
                picBox_QR.Image = QR_Performer;
            }
        }

    }
}
