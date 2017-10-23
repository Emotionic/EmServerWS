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
            this.lab_desc1 = new System.Windows.Forms.Label();
            this.lab_deskInfo_Count = new System.Windows.Forms.Label();
            this.lab_desc2 = new System.Windows.Forms.Label();
            this.lab_desc4 = new System.Windows.Forms.Label();
            this.lab_desc5 = new System.Windows.Forms.Label();
            this.lab_IP = new System.Windows.Forms.Label();
            this.lab_desc6 = new System.Windows.Forms.Label();
            this.picBox_QR_P = new System.Windows.Forms.PictureBox();
            this.lab_descQR_P = new System.Windows.Forms.Label();
            this.btnClsLog = new System.Windows.Forms.Button();
            this.tb_Log = new System.Windows.Forms.RichTextBox();
            this.btnToggleTopMost = new System.Windows.Forms.Button();
            this.lab_descQR_A = new System.Windows.Forms.Label();
            this.picBox_QR_A = new System.Windows.Forms.PictureBox();
            this.lab_WSCount = new System.Windows.Forms.Label();
            this.lab_descInfo_Emserver = new System.Windows.Forms.Label();
            this.lab_descInfo_EmKinectJoin = new System.Windows.Forms.Label();
            this.lab_descInfo_EmClient = new System.Windows.Forms.Label();
            this.lab_ClientCount = new System.Windows.Forms.Label();
            this.picBox_ServLamp = new System.Windows.Forms.PictureBox();
            this.picBox_KJLamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ServLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_KJLamp)).BeginInit();
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
            this.picboc_Emotionic.Click += new System.EventHandler(this.picboc_Emotionic_Click);
            // 
            // lab_Pin
            // 
            this.lab_Pin.AutoSize = true;
            this.lab_Pin.Font = new System.Drawing.Font("メイリオ", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_Pin.Location = new System.Drawing.Point(138, 267);
            this.lab_Pin.Name = "lab_Pin";
            this.lab_Pin.Size = new System.Drawing.Size(111, 54);
            this.lab_Pin.TabIndex = 1;
            this.lab_Pin.Text = "0000";
            // 
            // lab_desc1
            // 
            this.lab_desc1.AutoSize = true;
            this.lab_desc1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc1.Location = new System.Drawing.Point(18, 104);
            this.lab_desc1.Name = "lab_desc1";
            this.lab_desc1.Size = new System.Drawing.Size(350, 40);
            this.lab_desc1.TabIndex = 3;
            this.lab_desc1.Text = "Emotionicアプリを起動し、右のQRコードを読み取るか、\r\n以下の情報を入力してセットアップを実行してください。";
            this.lab_desc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_deskInfo_Count
            // 
            this.lab_deskInfo_Count.AutoSize = true;
            this.lab_deskInfo_Count.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_deskInfo_Count.Location = new System.Drawing.Point(407, 31);
            this.lab_deskInfo_Count.Name = "lab_deskInfo_Count";
            this.lab_deskInfo_Count.Size = new System.Drawing.Size(75, 20);
            this.lab_deskInfo_Count.TabIndex = 4;
            this.lab_deskInfo_Count.Text = "総接続数 : ";
            // 
            // lab_desc2
            // 
            this.lab_desc2.AutoSize = true;
            this.lab_desc2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc2.Location = new System.Drawing.Point(382, 12);
            this.lab_desc2.Name = "lab_desc2";
            this.lab_desc2.Size = new System.Drawing.Size(55, 20);
            this.lab_desc2.TabIndex = 5;
            this.lab_desc2.Text = "<情報>";
            // 
            // lab_desc4
            // 
            this.lab_desc4.AutoSize = true;
            this.lab_desc4.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc4.Location = new System.Drawing.Point(28, 261);
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
            this.lab_desc5.Location = new System.Drawing.Point(25, 161);
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
            this.lab_IP.Location = new System.Drawing.Point(32, 189);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(323, 52);
            this.lab_IP.TabIndex = 11;
            this.lab_IP.Text = "000.000.000.000";
            // 
            // lab_desc6
            // 
            this.lab_desc6.AutoSize = true;
            this.lab_desc6.Font = new System.Drawing.Font("メイリオ", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc6.Location = new System.Drawing.Point(10, 341);
            this.lab_desc6.Name = "lab_desc6";
            this.lab_desc6.Size = new System.Drawing.Size(48, 17);
            this.lab_desc6.TabIndex = 12;
            this.lab_desc6.Text = "<ログ>";
            // 
            // picBox_QR_P
            // 
            this.picBox_QR_P.Location = new System.Drawing.Point(392, 87);
            this.picBox_QR_P.Name = "picBox_QR_P";
            this.picBox_QR_P.Size = new System.Drawing.Size(256, 256);
            this.picBox_QR_P.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_QR_P.TabIndex = 7;
            this.picBox_QR_P.TabStop = false;
            // 
            // lab_descQR_P
            // 
            this.lab_descQR_P.AutoSize = true;
            this.lab_descQR_P.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_descQR_P.Location = new System.Drawing.Point(382, 63);
            this.lab_descQR_P.Name = "lab_descQR_P";
            this.lab_descQR_P.Size = new System.Drawing.Size(129, 18);
            this.lab_descQR_P.TabIndex = 14;
            this.lab_descQR_P.Text = "<パフォーマー用QR>";
            // 
            // btnClsLog
            // 
            this.btnClsLog.Location = new System.Drawing.Point(870, 546);
            this.btnClsLog.Name = "btnClsLog";
            this.btnClsLog.Size = new System.Drawing.Size(75, 23);
            this.btnClsLog.TabIndex = 15;
            this.btnClsLog.Text = "クリア";
            this.btnClsLog.UseVisualStyleBackColor = true;
            this.btnClsLog.Click += new System.EventHandler(this.btnClsLog_Click);
            // 
            // tb_Log
            // 
            this.tb_Log.DetectUrls = false;
            this.tb_Log.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tb_Log.Location = new System.Drawing.Point(12, 361);
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.ReadOnly = true;
            this.tb_Log.Size = new System.Drawing.Size(933, 179);
            this.tb_Log.TabIndex = 16;
            this.tb_Log.Text = "";
            this.tb_Log.WordWrap = false;
            // 
            // btnToggleTopMost
            // 
            this.btnToggleTopMost.Location = new System.Drawing.Point(12, 546);
            this.btnToggleTopMost.Name = "btnToggleTopMost";
            this.btnToggleTopMost.Size = new System.Drawing.Size(100, 23);
            this.btnToggleTopMost.TabIndex = 17;
            this.btnToggleTopMost.Text = "最前面にする";
            this.btnToggleTopMost.UseVisualStyleBackColor = true;
            this.btnToggleTopMost.Click += new System.EventHandler(this.btnToggleTopMost_Click);
            // 
            // lab_descQR_A
            // 
            this.lab_descQR_A.AutoSize = true;
            this.lab_descQR_A.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_descQR_A.Location = new System.Drawing.Point(663, 63);
            this.lab_descQR_A.Name = "lab_descQR_A";
            this.lab_descQR_A.Size = new System.Drawing.Size(81, 18);
            this.lab_descQR_A.TabIndex = 19;
            this.lab_descQR_A.Text = "<観客用QR>";
            // 
            // picBox_QR_A
            // 
            this.picBox_QR_A.Location = new System.Drawing.Point(666, 87);
            this.picBox_QR_A.Name = "picBox_QR_A";
            this.picBox_QR_A.Size = new System.Drawing.Size(256, 256);
            this.picBox_QR_A.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_QR_A.TabIndex = 18;
            this.picBox_QR_A.TabStop = false;
            // 
            // lab_WSCount
            // 
            this.lab_WSCount.AutoSize = true;
            this.lab_WSCount.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_WSCount.Location = new System.Drawing.Point(488, 31);
            this.lab_WSCount.Name = "lab_WSCount";
            this.lab_WSCount.Size = new System.Drawing.Size(17, 20);
            this.lab_WSCount.TabIndex = 20;
            this.lab_WSCount.Text = "0";
            // 
            // lab_descInfo_Emserver
            // 
            this.lab_descInfo_Emserver.AutoSize = true;
            this.lab_descInfo_Emserver.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_descInfo_Emserver.Location = new System.Drawing.Point(645, 31);
            this.lab_descInfo_Emserver.Name = "lab_descInfo_Emserver";
            this.lab_descInfo_Emserver.Size = new System.Drawing.Size(84, 20);
            this.lab_descInfo_Emserver.TabIndex = 21;
            this.lab_descInfo_Emserver.Text = "EmServer : ";
            // 
            // lab_descInfo_EmKinectJoin
            // 
            this.lab_descInfo_EmKinectJoin.AutoSize = true;
            this.lab_descInfo_EmKinectJoin.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_descInfo_EmKinectJoin.Location = new System.Drawing.Point(769, 31);
            this.lab_descInfo_EmKinectJoin.Name = "lab_descInfo_EmKinectJoin";
            this.lab_descInfo_EmKinectJoin.Size = new System.Drawing.Size(108, 20);
            this.lab_descInfo_EmKinectJoin.TabIndex = 22;
            this.lab_descInfo_EmKinectJoin.Text = "EmKinectJoin : ";
            // 
            // lab_descInfo_EmClient
            // 
            this.lab_descInfo_EmClient.AutoSize = true;
            this.lab_descInfo_EmClient.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_descInfo_EmClient.Location = new System.Drawing.Point(522, 31);
            this.lab_descInfo_EmClient.Name = "lab_descInfo_EmClient";
            this.lab_descInfo_EmClient.Size = new System.Drawing.Size(88, 20);
            this.lab_descInfo_EmClient.TabIndex = 23;
            this.lab_descInfo_EmClient.Text = "観客接続数 : ";
            // 
            // lab_ClientCount
            // 
            this.lab_ClientCount.AutoSize = true;
            this.lab_ClientCount.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_ClientCount.Location = new System.Drawing.Point(612, 31);
            this.lab_ClientCount.Name = "lab_ClientCount";
            this.lab_ClientCount.Size = new System.Drawing.Size(17, 20);
            this.lab_ClientCount.TabIndex = 24;
            this.lab_ClientCount.Text = "0";
            // 
            // picBox_ServLamp
            // 
            this.picBox_ServLamp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_ServLamp.Location = new System.Drawing.Point(735, 31);
            this.picBox_ServLamp.Name = "picBox_ServLamp";
            this.picBox_ServLamp.Size = new System.Drawing.Size(20, 20);
            this.picBox_ServLamp.TabIndex = 25;
            this.picBox_ServLamp.TabStop = false;
            // 
            // picBox_KJLamp
            // 
            this.picBox_KJLamp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_KJLamp.Location = new System.Drawing.Point(883, 31);
            this.picBox_KJLamp.Name = "picBox_KJLamp";
            this.picBox_KJLamp.Size = new System.Drawing.Size(20, 20);
            this.picBox_KJLamp.TabIndex = 26;
            this.picBox_KJLamp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 573);
            this.Controls.Add(this.picBox_KJLamp);
            this.Controls.Add(this.picBox_ServLamp);
            this.Controls.Add(this.lab_ClientCount);
            this.Controls.Add(this.lab_descInfo_EmClient);
            this.Controls.Add(this.lab_descInfo_EmKinectJoin);
            this.Controls.Add(this.lab_descInfo_Emserver);
            this.Controls.Add(this.lab_WSCount);
            this.Controls.Add(this.lab_descQR_A);
            this.Controls.Add(this.picBox_QR_A);
            this.Controls.Add(this.btnToggleTopMost);
            this.Controls.Add(this.tb_Log);
            this.Controls.Add(this.btnClsLog);
            this.Controls.Add(this.lab_descQR_P);
            this.Controls.Add(this.picBox_QR_P);
            this.Controls.Add(this.lab_desc6);
            this.Controls.Add(this.lab_IP);
            this.Controls.Add(this.lab_desc5);
            this.Controls.Add(this.lab_desc4);
            this.Controls.Add(this.lab_desc2);
            this.Controls.Add(this.lab_deskInfo_Count);
            this.Controls.Add(this.lab_desc1);
            this.Controls.Add(this.lab_Pin);
            this.Controls.Add(this.picboc_Emotionic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Emotionic Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_QR_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_ServLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_KJLamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picboc_Emotionic;
        private System.Windows.Forms.Label lab_Pin;
        private System.Windows.Forms.Label lab_desc1;
        private System.Windows.Forms.Label lab_deskInfo_Count;
        private System.Windows.Forms.Label lab_desc2;
        private System.Windows.Forms.Label lab_desc4;
        private System.Windows.Forms.Label lab_desc5;
        private System.Windows.Forms.Label lab_IP;
        private System.Windows.Forms.Label lab_desc6;
        private System.Windows.Forms.PictureBox picBox_QR_P;
        private System.Windows.Forms.Label lab_descQR_P;
        private System.Windows.Forms.Button btnClsLog;
        private System.Windows.Forms.RichTextBox tb_Log;
        private System.Windows.Forms.Button btnToggleTopMost;
        private System.Windows.Forms.Label lab_descQR_A;
        private System.Windows.Forms.PictureBox picBox_QR_A;
        private System.Windows.Forms.Label lab_WSCount;
        private System.Windows.Forms.Label lab_descInfo_Emserver;
        private System.Windows.Forms.Label lab_descInfo_EmKinectJoin;
        private System.Windows.Forms.Label lab_descInfo_EmClient;
        private System.Windows.Forms.Label lab_ClientCount;
        private System.Windows.Forms.PictureBox picBox_ServLamp;
        private System.Windows.Forms.PictureBox picBox_KJLamp;
    }
}

