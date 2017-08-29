using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmServerWS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // デバッグ用
#if DEBUG
            check_debug.Visible = true;
#endif

            this.Size = Normal;

            // Generate pin
            var rnd = new Random(Environment.TickCount + 810);
            int pin = 0;
            for (var i = 0; i < 4; i++)
            {
                pin *= 10;
                pin += rnd.Next(0, 10);
            }
            lab_Pin.Text = pin.ToString();

            // Start server
            _server = new Server(pin);

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

        private readonly Size Normal = new Size(303, 247);
        private readonly Size LogMode = new Size(574, 439);

        private Server _server;

        private void check_showLog_CheckedChanged(object sender, EventArgs e)
        {
            if (check_showLog.Checked)
            {
                this.Size = LogMode;
            }
            else
            {
                this.Size = Normal;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dlg = MessageBox.Show("Emotionic Server WSを終了しますか？\n(Emotionic Server Unityも同時終了します。)", "終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlg == DialogResult.OK)
            {
                //EmServerのプロセスを取得
                var ps = System.Diagnostics.Process.GetProcessesByName("EmServerUnity");

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

        private void check_debug_CheckedChanged(object sender, EventArgs e)
        {
            if (check_debug.Checked)
            {
                this.Size = LogMode;
                panel_debug.Visible = true;
            }
            else
            {
                this.Size = Normal;
                panel_debug.Visible = false;
            }

        }

        private void check_Calibrated_CheckedChanged(object sender, EventArgs e)
        {
            _server.isCalibrated = check_Calibrated.Checked;
        }

    }
}
