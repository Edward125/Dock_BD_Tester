namespace Dock_BD_Tester
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.txtSnLength = new System.Windows.Forms.TextBox();
            this.txtSnHead = new System.Windows.Forms.TextBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.txtTestLogFolder = new System.Windows.Forms.TextBox();
            this.txtCommLogFolder = new System.Windows.Forms.TextBox();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.txtSysLogFolder = new System.Windows.Forms.TextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.txtBackupFolder = new System.Windows.Forms.TextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.skinLabel2);
            this.skinGroupBox1.Controls.Add(this.skinLabel1);
            this.skinGroupBox1.Controls.Add(this.txtSnLength);
            this.skinGroupBox1.Controls.Add(this.txtSnHead);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(32, 51);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(377, 59);
            this.skinGroupBox1.TabIndex = 0;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "条码设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(253, 28);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(56, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "条码长度";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(6, 30);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(68, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "条码头设置";
            // 
            // txtSnLength
            // 
            this.txtSnLength.Location = new System.Drawing.Point(315, 24);
            this.txtSnLength.Name = "txtSnLength";
            this.txtSnLength.Size = new System.Drawing.Size(46, 23);
            this.txtSnLength.TabIndex = 1;
            this.txtSnLength.TextChanged += new System.EventHandler(this.txtSnLength_TextChanged);
            this.txtSnLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSnLength_KeyPress);
            // 
            // txtSnHead
            // 
            this.txtSnHead.Location = new System.Drawing.Point(80, 28);
            this.txtSnHead.Name = "txtSnHead";
            this.txtSnHead.Size = new System.Drawing.Size(100, 23);
            this.txtSnHead.TabIndex = 0;
            this.txtSnHead.TextChanged += new System.EventHandler(this.txtSnHead_TextChanged);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.txtTestLogFolder);
            this.skinGroupBox2.Controls.Add(this.txtCommLogFolder);
            this.skinGroupBox2.Controls.Add(this.skinLabel7);
            this.skinGroupBox2.Controls.Add(this.skinLabel6);
            this.skinGroupBox2.Controls.Add(this.txtSysLogFolder);
            this.skinGroupBox2.Controls.Add(this.skinLabel5);
            this.skinGroupBox2.Controls.Add(this.txtBackupFolder);
            this.skinGroupBox2.Controls.Add(this.skinLabel3);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(32, 127);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(377, 140);
            this.skinGroupBox2.TabIndex = 1;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "文件夹设置";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.SystemColors.Control;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtTestLogFolder
            // 
            this.txtTestLogFolder.Location = new System.Drawing.Point(89, 79);
            this.txtTestLogFolder.Name = "txtTestLogFolder";
            this.txtTestLogFolder.Size = new System.Drawing.Size(272, 23);
            this.txtTestLogFolder.TabIndex = 11;
            this.txtTestLogFolder.TextChanged += new System.EventHandler(this.txtTestLogFolder_TextChanged);
            this.txtTestLogFolder.DoubleClick += new System.EventHandler(this.txtTestLogFolder_DoubleClick);
            // 
            // txtCommLogFolder
            // 
            this.txtCommLogFolder.Location = new System.Drawing.Point(89, 50);
            this.txtCommLogFolder.Name = "txtCommLogFolder";
            this.txtCommLogFolder.Size = new System.Drawing.Size(272, 23);
            this.txtCommLogFolder.TabIndex = 10;
            this.txtCommLogFolder.TextChanged += new System.EventHandler(this.txtCommLogFolder_TextChanged);
            this.txtCommLogFolder.DoubleClick += new System.EventHandler(this.txtCommLogFolder_DoubleClick);
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(6, 82);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(78, 17);
            this.skinLabel7.TabIndex = 9;
            this.skinLabel7.Text = "测试log路径:";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(7, 52);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(78, 17);
            this.skinLabel6.TabIndex = 8;
            this.skinLabel6.Text = "命令log路径:";
            // 
            // txtSysLogFolder
            // 
            this.txtSysLogFolder.Location = new System.Drawing.Point(89, 21);
            this.txtSysLogFolder.Name = "txtSysLogFolder";
            this.txtSysLogFolder.Size = new System.Drawing.Size(272, 23);
            this.txtSysLogFolder.TabIndex = 7;
            this.txtSysLogFolder.TextChanged += new System.EventHandler(this.txtSysLogFolder_TextChanged);
            this.txtSysLogFolder.DoubleClick += new System.EventHandler(this.txtSysLogFolder_DoubleClick);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(6, 23);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(78, 17);
            this.skinLabel5.TabIndex = 6;
            this.skinLabel5.Text = "系统log路径:";
            // 
            // txtBackupFolder
            // 
            this.txtBackupFolder.Location = new System.Drawing.Point(89, 107);
            this.txtBackupFolder.Name = "txtBackupFolder";
            this.txtBackupFolder.Size = new System.Drawing.Size(272, 23);
            this.txtBackupFolder.TabIndex = 3;
            this.txtBackupFolder.TextChanged += new System.EventHandler(this.txtBackupFolder_TextChanged);
            this.txtBackupFolder.DoubleClick += new System.EventHandler(this.txtBackupFolder_DoubleClick);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(6, 110);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(78, 17);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "Backup路径:";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 283);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSetting";
            this.Text = "frmSetting";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSetting_FormClosing);
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox1.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            this.skinGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.TextBox txtSnLength;
        private System.Windows.Forms.TextBox txtSnHead;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private System.Windows.Forms.TextBox txtTestLogFolder;
        private System.Windows.Forms.TextBox txtCommLogFolder;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private System.Windows.Forms.TextBox txtSysLogFolder;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private System.Windows.Forms.TextBox txtBackupFolder;
        private CCWin.SkinControl.SkinLabel skinLabel3;
    }
}