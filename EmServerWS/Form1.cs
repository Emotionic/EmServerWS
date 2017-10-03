using System;
using System.IO;
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

            // Get IP
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

            // Generate pin
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

            // Create 
            QR_Performer = CreateQR(true, lab_IP.Text, lab_Pin.Text);
            QR_Audience = CreateQR(false, lab_IP.Text, lab_Pin.Text);
            picBox_QR.Image = QR_Performer;

            // Start server
            _server = new Server(pin, lab_IP.Text, QR_Audience);

            _server.LatestLog.mChanged += value =>
            {
                tb_Log.SelectionStart = 0;
                tb_Log.SelectionFont = new Font("メイリオ", 9, FontStyle.Regular);
                tb_Log.SelectionColor = Color.Black;
                tb_Log.SelectedText = $"[{DateTime.Now}] {value}\n";
            };

            _server.Connections.mChanged += value =>
            {
                lab_WSCount.Text = "接続数：" + value;
            };

            _server.Start();

            // EmServer(Unity)の起動
            if (System.IO.File.Exists(Environment.CurrentDirectory + @"\EmServer\EmServer.exe"))
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

        private void check_AudienceQR_CheckedChanged(object sender, EventArgs e)
        {
            if (check_AudienceQR.Checked)
            {
                picBox_QR.Image = QR_Audience;
                lab_descQR.Text = "観客用QR";
            } else
            {
                picBox_QR.Image = QR_Performer;
                lab_descQR.Text = "パフォーマー用QR";
            }
        }

        private void btnClsLog_Click(object sender, EventArgs e)
        {
            tb_Log.Clear();
        }

        private void picBox_QR_Click(object sender, EventArgs e)
        {
            check_AudienceQR.Checked = !check_AudienceQR.Checked;
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
