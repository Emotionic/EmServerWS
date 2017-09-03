namespace EmServerWS
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picboc_Emotionic = new System.Windows.Forms.PictureBox();
            this.lab_Pin = new System.Windows.Forms.Label();
            this.tb_Log = new System.Windows.Forms.TextBox();
            this.lab_desc1 = new System.Windows.Forms.Label();
            this.lab_WSCount = new System.Windows.Forms.Label();
            this.lab_desc2 = new System.Windows.Forms.Label();
            this.lab_desc4 = new System.Windows.Forms.Label();
            this.lab_desc5 = new System.Windows.Forms.Label();
            this.lab_IP = new System.Windows.Forms.Label();
            this.lab_desc6 = new System.Windows.Forms.Label();
            this.picBox_QR = new System.Windows.Forms.PictureBox();
            this.check_AudienceQR = new System.Windows.Forms.CheckBox();
            this.lab_descQR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR)).BeginInit();
            this.SuspendLayout();
            // 
            // picboc_Emotionic
            // 
            this.picboc_Emotionic.Image = ((System.Drawing.Image)(resources.GetObject("picboc_Emotionic.Image")));
            this.picboc_Emotionic.Location = new System.Drawing.Point(54, 12);
            this.picboc_Emotionic.Name = "picboc_Emotionic";
            this.picboc_Emotionic.Size = new System.Drawing.Size(260, 70);
            this.picboc_Emotionic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboc_Emotionic.TabIndex = 0;
            this.picboc_Emotionic.TabStop = false;
            // 
            // lab_Pin
            // 
            this.lab_Pin.AutoSize = true;
            this.lab_Pin.Font = new System.Drawing.Font("メイリオ", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_Pin.Location = new System.Drawing.Point(134, 251);
            this.lab_Pin.Name = "lab_Pin";
            this.lab_Pin.Size = new System.Drawing.Size(116, 55);
            this.lab_Pin.TabIndex = 1;
            this.lab_Pin.Text = "0000";
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(12, 361);
            this.tb_Log.Multiline = true;
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.ReadOnly = true;
            this.tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Log.Size = new System.Drawing.Size(659, 179);
            this.tb_Log.TabIndex = 2;
            // 
            // lab_desc1
            // 
            this.lab_desc1.AutoSize = true;
            this.lab_desc1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc1.Location = new System.Drawing.Point(42, 101);
            this.lab_desc1.Name = "lab_desc1";
            this.lab_desc1.Size = new System.Drawing.Size(293, 26);
            this.lab_desc1.TabIndex = 3;
            this.lab_desc1.Text = "Emotionicアプリを起動し、右のQRコードを読み取るか、\r\n以下の情報を入力してセットアップを実行してください。";
            this.lab_desc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_WSCount
            // 
            this.lab_WSCount.AutoSize = true;
            this.lab_WSCount.Location = new System.Drawing.Point(401, 31);
            this.lab_WSCount.Name = "lab_WSCount";
            this.lab_WSCount.Size = new System.Drawing.Size(57, 12);
            this.lab_WSCount.TabIndex = 4;
            this.lab_WSCount.Text = "接続数 : 0";
            // 
            // lab_desc2
            // 
            this.lab_desc2.AutoSize = true;
            this.lab_desc2.Location = new System.Drawing.Point(382, 12);
            this.lab_desc2.Name = "lab_desc2";
            this.lab_desc2.Size = new System.Drawing.Size(41, 12);
            this.lab_desc2.TabIndex = 5;
            this.lab_desc2.Text = "<情報>";
            // 
            // lab_desc4
            // 
            this.lab_desc4.AutoSize = true;
            this.lab_desc4.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc4.Location = new System.Drawing.Point(24, 245);
            this.lab_desc4.Name = "lab_desc4";
            this.lab_desc4.Size = new System.Drawing.Size(65, 28);
            this.lab_desc4.TabIndex = 9;
            this.lab_desc4.Text = "PIN : ";
            this.lab_desc4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_desc5
            // 
            this.lab_desc5.AutoSize = true;
            this.lab_desc5.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc5.Location = new System.Drawing.Point(21, 145);
            this.lab_desc5.Name = "lab_desc5";
            this.lab_desc5.Size = new System.Drawing.Size(127, 28);
            this.lab_desc5.TabIndex = 10;
            this.lab_desc5.Text = "IPアドレス : ";
            this.lab_desc5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_IP
            // 
            this.lab_IP.AutoSize = true;
            this.lab_IP.Font = new System.Drawing.Font("メイリオ", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_IP.Location = new System.Drawing.Point(28, 173);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(323, 52);
            this.lab_IP.TabIndex = 11;
            this.lab_IP.Text = "000.000.000.000";
            // 
            // lab_desc6
            // 
            this.lab_desc6.AutoSize = true;
            this.lab_desc6.Location = new System.Drawing.Point(10, 341);
            this.lab_desc6.Name = "lab_desc6";
            this.lab_desc6.Size = new System.Drawing.Size(35, 12);
            this.lab_desc6.TabIndex = 12;
            this.lab_desc6.Text = "<ログ>";
            // 
            // picBox_QR
            // 
            this.picBox_QR.Location = new System.Drawing.Point(392, 69);
            this.picBox_QR.Name = "picBox_QR";
            this.picBox_QR.Size = new System.Drawing.Size(256, 256);
            this.picBox_QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_QR.TabIndex = 7;
            this.picBox_QR.TabStop = false;
            // 
            // check_AudienceQR
            // 
            this.check_AudienceQR.AutoSize = true;
            this.check_AudienceQR.Location = new System.Drawing.Point(392, 332);
            this.check_AudienceQR.Name = "check_AudienceQR";
            this.check_AudienceQR.Size = new System.Drawing.Size(76, 16);
            this.check_AudienceQR.TabIndex = 13;
            this.check_AudienceQR.Text = "観客用QR";
            this.check_AudienceQR.UseVisualStyleBackColor = true;
            this.check_AudienceQR.CheckedChanged += new System.EventHandler(this.check_AudienceQR_CheckedChanged);
            // 
            // lab_descQR
            // 
            this.lab_descQR.AutoSize = true;
            this.lab_descQR.Location = new System.Drawing.Point(382, 53);
            this.lab_descQR.Name = "lab_descQR";
            this.lab_descQR.Size = new System.Drawing.Size(100, 12);
            this.lab_descQR.TabIndex = 14;
            this.lab_descQR.Text = "<パフォーマー用QR>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 549);
            this.Controls.Add(this.lab_descQR);
            this.Controls.Add(this.check_AudienceQR);
            this.Controls.Add(this.picBox_QR);
            this.Controls.Add(this.lab_desc6);
            this.Controls.Add(this.lab_IP);
            this.Controls.Add(this.lab_desc5);
            this.Controls.Add(this.lab_desc4);
            this.Controls.Add(this.lab_desc2);
            this.Controls.Add(this.lab_WSCount);
            this.Controls.Add(this.lab_desc1);
            this.Controls.Add(this.tb_Log);
            this.Controls.Add(this.lab_Pin);
            this.Controls.Add(this.picboc_Emotionic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Emotionic Server";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboc_Emotionic;
        private System.Windows.Forms.Label lab_Pin;
        private System.Windows.Forms.TextBox tb_Log;
        private System.Windows.Forms.Label lab_desc1;
        private System.Windows.Forms.Label lab_WSCount;
        private System.Windows.Forms.Label lab_desc2;
        private System.Windows.Forms.Label lab_desc4;
        private System.Windows.Forms.Label lab_desc5;
        private System.Windows.Forms.Label lab_IP;
        private System.Windows.Forms.Label lab_desc6;
        private System.Windows.Forms.PictureBox picBox_QR;
        private System.Windows.Forms.CheckBox check_AudienceQR;
        private System.Windows.Forms.Label lab_descQR;
    }
}

