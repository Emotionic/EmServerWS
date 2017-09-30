using System;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace EmServerWS
{
    public partial class QRDiag : Form
    {
        public QRDiag()
        {
            InitializeComponent();
        }

        private void check_isPerformer_CheckedChanged(object sender, EventArgs e)
        {
            tb_PIN.Enabled = check_isPerformer.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var qrdata = "{";
            qrdata += "\"isPerformer\" : " + (check_isPerformer.Checked ? "true" : "false") + ", ";
            qrdata += "\"IP\" : \"" + tb_IP.Text + "\", ";
            qrdata += "\"PIN\" : \"" + (check_isPerformer.Checked ? tb_PIN.Text : "") + "\" ";
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
            
            var bmp = writer.Write(qrdata);

            var sfd = new SaveFileDialog();
            sfd.FileName = "qr.png";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            sfd.Filter = "PNG Image(*.png)|*.png";
            sfd.Title = "名前を付けて保存";
            sfd.RestoreDirectory = true;
            
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                MessageBox.Show("保存が完了しました。", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bmp.Dispose();
        }
    }
}
