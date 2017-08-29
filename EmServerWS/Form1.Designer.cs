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
            this.check_showLog = new System.Windows.Forms.CheckBox();
            this.check_debug = new System.Windows.Forms.CheckBox();
            this.panel_debug = new System.Windows.Forms.Panel();
            this.lab_desc3 = new System.Windows.Forms.Label();
            this.lab_desc4 = new System.Windows.Forms.Label();
            this.lab_desc5 = new System.Windows.Forms.Label();
            this.lab_IP = new System.Windows.Forms.Label();
            this.lab_desc6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).BeginInit();
            this.panel_debug.SuspendLayout();
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
            this.lab_Pin.Location = new System.Drawing.Point(127, 216);
            this.lab_Pin.Name = "lab_Pin";
            this.lab_Pin.Size = new System.Drawing.Size(116, 55);
            this.lab_Pin.TabIndex = 1;
            this.lab_Pin.Text = "0000";
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(12, 344);
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
            this.lab_desc1.Location = new System.Drawing.Point(51, 95);
            this.lab_desc1.Name = "lab_desc1";
            this.lab_desc1.Size = new System.Drawing.Size(263, 26);
            this.lab_desc1.TabIndex = 3;
            this.lab_desc1.Text = "Emotionicアプリを起動し、以下の情報を入力して\r\nセットアップを実行してください。";
            this.lab_desc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_WSCount
            // 
            this.lab_WSCount.AutoSize = true;
            this.lab_WSCount.Location = new System.Drawing.Point(401, 37);
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
            // check_showLog
            // 
            this.check_showLog.AutoSize = true;
            this.check_showLog.Location = new System.Drawing.Point(12, 292);
            this.check_showLog.Name = "check_showLog";
            this.check_showLog.Size = new System.Drawing.Size(76, 16);
            this.check_showLog.TabIndex = 6;
            this.check_showLog.Text = "ログの表示";
            this.check_showLog.UseVisualStyleBackColor = true;
            this.check_showLog.CheckedChanged += new System.EventHandler(this.check_showLog_CheckedChanged);
            // 
            // check_debug
            // 
            this.check_debug.AutoSize = true;
            this.check_debug.Location = new System.Drawing.Point(303, 292);
            this.check_debug.Name = "check_debug";
            this.check_debug.Size = new System.Drawing.Size(60, 16);
            this.check_debug.TabIndex = 7;
            this.check_debug.Text = "デバッグ";
            this.check_debug.UseVisualStyleBackColor = true;
            this.check_debug.Visible = false;
            this.check_debug.CheckedChanged += new System.EventHandler(this.check_debug_CheckedChanged);
            // 
            // panel_debug
            // 
            this.panel_debug.Controls.Add(this.lab_desc3);
            this.panel_debug.Location = new System.Drawing.Point(422, 216);
            this.panel_debug.Name = "panel_debug";
            this.panel_debug.Size = new System.Drawing.Size(200, 100);
            this.panel_debug.TabIndex = 8;
            this.panel_debug.Visible = false;
            // 
            // lab_desc3
            // 
            this.lab_desc3.AutoSize = true;
            this.lab_desc3.Location = new System.Drawing.Point(10, 7);
            this.lab_desc3.Name = "lab_desc3";
            this.lab_desc3.Size = new System.Drawing.Size(53, 12);
            this.lab_desc3.TabIndex = 6;
            this.lab_desc3.Text = "<デバッグ>";
            // 
            // lab_desc4
            // 
            this.lab_desc4.AutoSize = true;
            this.lab_desc4.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc4.Location = new System.Drawing.Point(23, 212);
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
            this.lab_desc5.Location = new System.Drawing.Point(12, 132);
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
            this.lab_IP.Location = new System.Drawing.Point(19, 160);
            this.lab_IP.Name = "lab_IP";
            this.lab_IP.Size = new System.Drawing.Size(323, 52);
            this.lab_IP.TabIndex = 11;
            this.lab_IP.Text = "000.000.000.000";
            // 
            // lab_desc6
            // 
            this.lab_desc6.AutoSize = true;
            this.lab_desc6.Location = new System.Drawing.Point(10, 324);
            this.lab_desc6.Name = "lab_desc6";
            this.lab_desc6.Size = new System.Drawing.Size(35, 12);
            this.lab_desc6.TabIndex = 12;
            this.lab_desc6.Text = "<ログ>";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 531);
            this.Controls.Add(this.lab_desc6);
            this.Controls.Add(this.lab_IP);
            this.Controls.Add(this.lab_desc5);
            this.Controls.Add(this.lab_desc4);
            this.Controls.Add(this.panel_debug);
            this.Controls.Add(this.check_debug);
            this.Controls.Add(this.check_showLog);
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
            this.panel_debug.ResumeLayout(false);
            this.panel_debug.PerformLayout();
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
        private System.Windows.Forms.CheckBox check_showLog;
        private System.Windows.Forms.CheckBox check_debug;
        private System.Windows.Forms.Panel panel_debug;
        private System.Windows.Forms.Label lab_desc3;
        private System.Windows.Forms.Label lab_desc4;
        private System.Windows.Forms.Label lab_desc5;
        private System.Windows.Forms.Label lab_IP;
        private System.Windows.Forms.Label lab_desc6;
    }
}

