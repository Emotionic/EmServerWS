namespace JsonCreationTool
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnShowJson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbG = new System.Windows.Forms.ComboBox();
            this.tbGjp = new System.Windows.Forms.TextBox();
            this.tbGen = new System.Windows.Forms.TextBox();
            this.btnGAdd = new System.Windows.Forms.Button();
            this.btnGDel = new System.Windows.Forms.Button();
            this.btnEDel = new System.Windows.Forms.Button();
            this.btnEAdd = new System.Windows.Forms.Button();
            this.tbEen = new System.Windows.Forms.TextBox();
            this.tbEjp = new System.Windows.Forms.TextBox();
            this.cbE = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCDel = new System.Windows.Forms.Button();
            this.btnCAdd = new System.Windows.Forms.Button();
            this.tbCr = new System.Windows.Forms.TextBox();
            this.tbCjp = new System.Windows.Forms.TextBox();
            this.cbC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCg = new System.Windows.Forms.TextBox();
            this.tbCa = new System.Windows.Forms.TextBox();
            this.tbCb = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(588, 169);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "書き込み";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnShowJson
            // 
            this.btnShowJson.Location = new System.Drawing.Point(507, 169);
            this.btnShowJson.Name = "btnShowJson";
            this.btnShowJson.Size = new System.Drawing.Size(75, 23);
            this.btnShowJson.TabIndex = 1;
            this.btnShowJson.Text = "JSON表示";
            this.btnShowJson.UseVisualStyleBackColor = true;
            this.btnShowJson.Click += new System.EventHandler(this.btnShowJson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gesture";
            // 
            // cbG
            // 
            this.cbG.FormattingEnabled = true;
            this.cbG.Location = new System.Drawing.Point(463, 31);
            this.cbG.Name = "cbG";
            this.cbG.Size = new System.Drawing.Size(121, 20);
            this.cbG.TabIndex = 3;
            // 
            // tbGjp
            // 
            this.tbGjp.Location = new System.Drawing.Point(66, 31);
            this.tbGjp.Name = "tbGjp";
            this.tbGjp.Size = new System.Drawing.Size(100, 19);
            this.tbGjp.TabIndex = 4;
            // 
            // tbGen
            // 
            this.tbGen.Location = new System.Drawing.Point(181, 31);
            this.tbGen.Name = "tbGen";
            this.tbGen.Size = new System.Drawing.Size(100, 19);
            this.tbGen.TabIndex = 5;
            // 
            // btnGAdd
            // 
            this.btnGAdd.Location = new System.Drawing.Point(363, 29);
            this.btnGAdd.Name = "btnGAdd";
            this.btnGAdd.Size = new System.Drawing.Size(75, 23);
            this.btnGAdd.TabIndex = 7;
            this.btnGAdd.Text = "追加";
            this.btnGAdd.UseVisualStyleBackColor = true;
            this.btnGAdd.Click += new System.EventHandler(this.btnGAdd_Click);
            // 
            // btnGDel
            // 
            this.btnGDel.Location = new System.Drawing.Point(590, 29);
            this.btnGDel.Name = "btnGDel";
            this.btnGDel.Size = new System.Drawing.Size(75, 23);
            this.btnGDel.TabIndex = 8;
            this.btnGDel.Text = "削除";
            this.btnGDel.UseVisualStyleBackColor = true;
            this.btnGDel.Click += new System.EventHandler(this.btnGDel_Click);
            // 
            // btnEDel
            // 
            this.btnEDel.Location = new System.Drawing.Point(590, 69);
            this.btnEDel.Name = "btnEDel";
            this.btnEDel.Size = new System.Drawing.Size(75, 23);
            this.btnEDel.TabIndex = 15;
            this.btnEDel.Text = "削除";
            this.btnEDel.UseVisualStyleBackColor = true;
            this.btnEDel.Click += new System.EventHandler(this.btnEDel_Click);
            // 
            // btnEAdd
            // 
            this.btnEAdd.Location = new System.Drawing.Point(363, 69);
            this.btnEAdd.Name = "btnEAdd";
            this.btnEAdd.Size = new System.Drawing.Size(75, 23);
            this.btnEAdd.TabIndex = 14;
            this.btnEAdd.Text = "追加";
            this.btnEAdd.UseVisualStyleBackColor = true;
            this.btnEAdd.Click += new System.EventHandler(this.btnEAdd_Click);
            // 
            // tbEen
            // 
            this.tbEen.Location = new System.Drawing.Point(181, 71);
            this.tbEen.Name = "tbEen";
            this.tbEen.Size = new System.Drawing.Size(100, 19);
            this.tbEen.TabIndex = 12;
            // 
            // tbEjp
            // 
            this.tbEjp.Location = new System.Drawing.Point(66, 71);
            this.tbEjp.Name = "tbEjp";
            this.tbEjp.Size = new System.Drawing.Size(100, 19);
            this.tbEjp.TabIndex = 11;
            // 
            // cbE
            // 
            this.cbE.FormattingEnabled = true;
            this.cbE.Location = new System.Drawing.Point(463, 71);
            this.cbE.Name = "cbE";
            this.cbE.Size = new System.Drawing.Size(121, 20);
            this.cbE.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Effect";
            // 
            // btnCDel
            // 
            this.btnCDel.Location = new System.Drawing.Point(590, 132);
            this.btnCDel.Name = "btnCDel";
            this.btnCDel.Size = new System.Drawing.Size(75, 23);
            this.btnCDel.TabIndex = 22;
            this.btnCDel.Text = "削除";
            this.btnCDel.UseVisualStyleBackColor = true;
            this.btnCDel.Click += new System.EventHandler(this.btnCDel_Click);
            // 
            // btnCAdd
            // 
            this.btnCAdd.Location = new System.Drawing.Point(363, 132);
            this.btnCAdd.Name = "btnCAdd";
            this.btnCAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCAdd.TabIndex = 21;
            this.btnCAdd.Text = "追加";
            this.btnCAdd.UseVisualStyleBackColor = true;
            this.btnCAdd.Click += new System.EventHandler(this.btnCAdd_Click);
            // 
            // tbCr
            // 
            this.tbCr.Location = new System.Drawing.Point(191, 134);
            this.tbCr.Name = "tbCr";
            this.tbCr.Size = new System.Drawing.Size(26, 19);
            this.tbCr.TabIndex = 19;
            // 
            // tbCjp
            // 
            this.tbCjp.Location = new System.Drawing.Point(66, 134);
            this.tbCjp.Name = "tbCjp";
            this.tbCjp.Size = new System.Drawing.Size(100, 19);
            this.tbCjp.TabIndex = 18;
            // 
            // cbC
            // 
            this.cbC.FormattingEnabled = true;
            this.cbC.Location = new System.Drawing.Point(463, 134);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(121, 20);
            this.cbC.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 12);
            this.label6.TabIndex = 16;
            this.label6.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "日本語(表示名)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(179, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "英語(内部)";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Location = new System.Drawing.Point(5, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(665, 1);
            this.label9.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 12);
            this.label10.TabIndex = 27;
            this.label10.Text = "色(R,       G,       B,       A)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(66, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "日本語(表示名)";
            // 
            // tbCg
            // 
            this.tbCg.Location = new System.Drawing.Point(228, 134);
            this.tbCg.Name = "tbCg";
            this.tbCg.Size = new System.Drawing.Size(26, 19);
            this.tbCg.TabIndex = 28;
            // 
            // tbCa
            // 
            this.tbCa.Location = new System.Drawing.Point(303, 134);
            this.tbCa.Name = "tbCa";
            this.tbCa.Size = new System.Drawing.Size(26, 19);
            this.tbCa.TabIndex = 29;
            // 
            // tbCb
            // 
            this.tbCb.Location = new System.Drawing.Point(265, 134);
            this.tbCb.Name = "tbCb";
            this.tbCb.Size = new System.Drawing.Size(26, 19);
            this.tbCb.TabIndex = 29;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 169);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 30;
            this.btnLoad.Text = "読み込み";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 208);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tbCb);
            this.Controls.Add(this.tbCa);
            this.Controls.Add(this.tbCg);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCDel);
            this.Controls.Add(this.btnCAdd);
            this.Controls.Add(this.tbCr);
            this.Controls.Add(this.tbCjp);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEDel);
            this.Controls.Add(this.btnEAdd);
            this.Controls.Add(this.tbEen);
            this.Controls.Add(this.tbEjp);
            this.Controls.Add(this.cbE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGDel);
            this.Controls.Add(this.btnGAdd);
            this.Controls.Add(this.tbGen);
            this.Controls.Add(this.tbGjp);
            this.Controls.Add(this.cbG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowJson);
            this.Controls.Add(this.btnWrite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EmServerWS JsonCreationTool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnShowJson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbG;
        private System.Windows.Forms.TextBox tbGen;
        private System.Windows.Forms.Button btnGAdd;
        private System.Windows.Forms.Button btnGDel;
        private System.Windows.Forms.Button btnEDel;
        private System.Windows.Forms.Button btnEAdd;
        private System.Windows.Forms.TextBox tbEen;
        private System.Windows.Forms.TextBox tbEjp;
        private System.Windows.Forms.ComboBox cbE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCDel;
        private System.Windows.Forms.Button btnCAdd;
        private System.Windows.Forms.TextBox tbCr;
        private System.Windows.Forms.TextBox tbCjp;
        private System.Windows.Forms.ComboBox cbC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGjp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCg;
        private System.Windows.Forms.TextBox tbCa;
        private System.Windows.Forms.TextBox tbCb;
        private System.Windows.Forms.Button btnLoad;
    }
}

