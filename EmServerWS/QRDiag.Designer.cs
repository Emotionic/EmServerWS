namespace EmServerWS
{
    partial class QRDiag
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRDiag));
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_PIN = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labDesc1 = new System.Windows.Forms.Label();
            this.labDesc2 = new System.Windows.Forms.Label();
            this.check_isPerformer = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(143, 22);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(100, 19);
            this.tb_IP.TabIndex = 0;
            // 
            // tb_PIN
            // 
            this.tb_PIN.Enabled = false;
            this.tb_PIN.Location = new System.Drawing.Point(143, 61);
            this.tb_PIN.Name = "tb_PIN";
            this.tb_PIN.Size = new System.Drawing.Size(100, 19);
            this.tb_PIN.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(103, 145);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "画像を保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labDesc1
            // 
            this.labDesc1.AutoSize = true;
            this.labDesc1.Location = new System.Drawing.Point(37, 25);
            this.labDesc1.Name = "labDesc1";
            this.labDesc1.Size = new System.Drawing.Size(57, 12);
            this.labDesc1.TabIndex = 5;
            this.labDesc1.Text = "IPアドレス：";
            // 
            // labDesc2
            // 
            this.labDesc2.AutoSize = true;
            this.labDesc2.Location = new System.Drawing.Point(37, 64);
            this.labDesc2.Name = "labDesc2";
            this.labDesc2.Size = new System.Drawing.Size(29, 12);
            this.labDesc2.TabIndex = 6;
            this.labDesc2.Text = "PIN：";
            // 
            // check_isPerformer
            // 
            this.check_isPerformer.AutoSize = true;
            this.check_isPerformer.Location = new System.Drawing.Point(39, 109);
            this.check_isPerformer.Name = "check_isPerformer";
            this.check_isPerformer.Size = new System.Drawing.Size(79, 16);
            this.check_isPerformer.TabIndex = 2;
            this.check_isPerformer.Text = "パフォーマー";
            this.check_isPerformer.UseVisualStyleBackColor = true;
            this.check_isPerformer.CheckedChanged += new System.EventHandler(this.check_isPerformer_CheckedChanged);
            // 
            // QRDiag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 180);
            this.Controls.Add(this.labDesc2);
            this.Controls.Add(this.labDesc1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.check_isPerformer);
            this.Controls.Add(this.tb_PIN);
            this.Controls.Add(this.tb_IP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QRDiag";
            this.Text = "QR生成ダイアログ (デバッグ用)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_PIN;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labDesc1;
        private System.Windows.Forms.Label labDesc2;
        private System.Windows.Forms.CheckBox check_isPerformer;
    }
}