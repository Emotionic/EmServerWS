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
            this.check_Calibrated = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboc_Emotionic)).BeginInit();
            this.panel_debug.SuspendLayout();
            this.SuspendLayout();
            // 
            // picboc_Emotionic
            // 
            this.picboc_Emotionic.Image = ((System.Drawing.Image)(resources.GetObject("picboc_Emotionic.Image")));
            this.picboc_Emotionic.Location = new System.Drawing.Point(12, 12);
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
            this.lab_Pin.Location = new System.Drawing.Point(86, 127);
            this.lab_Pin.Name = "lab_Pin";
            this.lab_Pin.Size = new System.Drawing.Size(116, 55);
            this.lab_Pin.TabIndex = 1;
            this.lab_Pin.Text = "0000";
            // 
            // tb_Log
            // 
            this.tb_Log.Location = new System.Drawing.Point(13, 211);
            this.tb_Log.Multiline = true;
            this.tb_Log.Name = "tb_Log";
            this.tb_Log.ReadOnly = true;
            this.tb_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_Log.Size = new System.Drawing.Size(530, 179);
            this.tb_Log.TabIndex = 2;
            // 
            // lab_desc1
            // 
            this.lab_desc1.AutoSize = true;
            this.lab_desc1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab_desc1.Location = new System.Drawing.Point(12, 92);
            this.lab_desc1.Name = "lab_desc1";
            this.lab_desc1.Size = new System.Drawing.Size(267, 26);
            this.lab_desc1.TabIndex = 3;
            this.lab_desc1.Text = "開始するには、下のPINをアプリで入力してください。\r\nPIN:";
            this.lab_desc1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_WSCount
            // 
            this.lab_WSCount.AutoSize = true;
            this.lab_WSCount.Location = new System.Drawing.Point(314, 39);
            this.lab_WSCount.Name = "lab_WSCount";
            this.lab_WSCount.Size = new System.Drawing.Size(57, 12);
            this.lab_WSCount.TabIndex = 4;
            this.lab_WSCount.Text = "接続数 : 0";
            // 
            // lab_desc2
            // 
            this.lab_desc2.AutoSize = true;
            this.lab_desc2.Location = new System.Drawing.Point(295, 14);
            this.lab_desc2.Name = "lab_desc2";
            this.lab_desc2.Size = new System.Drawing.Size(41, 12);
            this.lab_desc2.TabIndex = 5;
            this.lab_desc2.Text = "<情報>";
            // 
            // check_showLog
            // 
            this.check_showLog.AutoSize = true;
            this.check_showLog.Location = new System.Drawing.Point(15, 183);
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
            this.check_debug.Location = new System.Drawing.Point(212, 183);
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
            this.panel_debug.Controls.Add(this.check_Calibrated);
            this.panel_debug.Controls.Add(this.lab_desc3);
            this.panel_debug.Location = new System.Drawing.Point(285, 99);
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
            // check_Calibrated
            // 
            this.check_Calibrated.AutoSize = true;
            this.check_Calibrated.Location = new System.Drawing.Point(31, 28);
            this.check_Calibrated.Name = "check_Calibrated";
            this.check_Calibrated.Size = new System.Drawing.Size(153, 16);
            this.check_Calibrated.TabIndex = 7;
            this.check_Calibrated.Text = "キャリブレーション済みにする";
            this.check_Calibrated.UseVisualStyleBackColor = true;
            this.check_Calibrated.CheckedChanged += new System.EventHandler(this.check_Calibrated_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 399);
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
        private System.Windows.Forms.CheckBox check_Calibrated;
        private System.Windows.Forms.Label lab_desc3;
    }
}

