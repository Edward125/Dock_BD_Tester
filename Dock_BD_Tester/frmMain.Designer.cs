namespace Dock_BD_Tester
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstCommand = new CCWin.SkinControl.SkinListBox();
            this.lblResult = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.lstBarcode = new CCWin.SkinControl.SkinListBox();
            this.skinGroupBox7 = new CCWin.SkinControl.SkinGroupBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.skinGroupBox3 = new CCWin.SkinControl.SkinGroupBox();
            this.btnRestart = new CCWin.SkinControl.SkinButton();
            this.btnSetting = new CCWin.SkinControl.SkinButton();
            this.btnQuery = new CCWin.SkinControl.SkinButton();
            this.btnStop = new CCWin.SkinControl.SkinButton();
            this.btnStart = new CCWin.SkinControl.SkinButton();
            this.skinGroupBox4 = new CCWin.SkinControl.SkinGroupBox();
            this.txtFPY = new CCWin.SkinControl.SkinTextBox();
            this.txtFail = new CCWin.SkinControl.SkinTextBox();
            this.txtPass = new CCWin.SkinControl.SkinTextBox();
            this.txtTotal = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox5 = new CCWin.SkinControl.SkinGroupBox();
            this.btnFresh = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.comboPLC = new System.Windows.Forms.ComboBox();
            this.spPLC = new System.IO.Ports.SerialPort(this.components);
            this.skinGroupBox6 = new CCWin.SkinControl.SkinGroupBox();
            this.lstStatus = new CCWin.SkinControl.SkinListBox();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox7.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            this.skinGroupBox3.SuspendLayout();
            this.skinGroupBox4.SuspendLayout();
            this.skinGroupBox5.SuspendLayout();
            this.skinGroupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCommand
            // 
            this.lstCommand.Back = null;
            this.lstCommand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstCommand.FormattingEnabled = true;
            this.lstCommand.ItemHeight = 18;
            this.lstCommand.Location = new System.Drawing.Point(6, 20);
            this.lstCommand.Name = "lstCommand";
            this.lstCommand.Size = new System.Drawing.Size(282, 166);
            this.lstCommand.TabIndex = 0;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Yellow;
            this.lblResult.BorderColor = System.Drawing.Color.White;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(562, 48);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(154, 64);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "WAIT";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Controls.Add(this.lstBarcode);
            this.skinGroupBox1.Controls.Add(this.skinGroupBox7);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(28, 151);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(291, 196);
            this.skinGroupBox1.TabIndex = 3;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = " Barcode List ";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lstBarcode
            // 
            this.lstBarcode.Back = null;
            this.lstBarcode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstBarcode.FormattingEnabled = true;
            this.lstBarcode.ItemHeight = 18;
            this.lstBarcode.Location = new System.Drawing.Point(9, 23);
            this.lstBarcode.Name = "lstBarcode";
            this.lstBarcode.Size = new System.Drawing.Size(273, 112);
            this.lstBarcode.TabIndex = 10;
            // 
            // skinGroupBox7
            // 
            this.skinGroupBox7.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox7.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox7.Controls.Add(this.txtBarcode);
            this.skinGroupBox7.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox7.Location = new System.Drawing.Point(6, 137);
            this.skinGroupBox7.Name = "skinGroupBox7";
            this.skinGroupBox7.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox7.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox7.Size = new System.Drawing.Size(279, 53);
            this.skinGroupBox7.TabIndex = 9;
            this.skinGroupBox7.TabStop = false;
            this.skinGroupBox7.Text = "此处刷入条码开始测试，条码以回车符结尾";
            this.skinGroupBox7.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox7.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox7.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Enabled = false;
            this.txtBarcode.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarcode.Location = new System.Drawing.Point(6, 20);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(267, 29);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.Text = "SF054678901234567890QWE";
            this.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Controls.Add(this.lstCommand);
            this.skinGroupBox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(325, 151);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox2.Size = new System.Drawing.Size(294, 196);
            this.skinGroupBox2.TabIndex = 4;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = " Command List ";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Dock_BD_Tester.Properties.Resources.dock;
            this.picTitle.Location = new System.Drawing.Point(78, 48);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(429, 87);
            this.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTitle.TabIndex = 5;
            this.picTitle.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(518, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "昆山凯耀电子科技有限公司 2015.10";
            // 
            // skinGroupBox3
            // 
            this.skinGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox3.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox3.Controls.Add(this.btnRestart);
            this.skinGroupBox3.Controls.Add(this.btnSetting);
            this.skinGroupBox3.Controls.Add(this.btnQuery);
            this.skinGroupBox3.Controls.Add(this.btnStop);
            this.skinGroupBox3.Controls.Add(this.btnStart);
            this.skinGroupBox3.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox3.Location = new System.Drawing.Point(625, 391);
            this.skinGroupBox3.Name = "skinGroupBox3";
            this.skinGroupBox3.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox3.Size = new System.Drawing.Size(157, 219);
            this.skinGroupBox3.TabIndex = 7;
            this.skinGroupBox3.TabStop = false;
            this.skinGroupBox3.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox3.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox3.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.Transparent;
            this.btnRestart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnRestart.DownBack = null;
            this.btnRestart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRestart.Location = new System.Drawing.Point(11, 178);
            this.btnRestart.MouseBack = null;
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.NormlBack = null;
            this.btnRestart.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnRestart.Size = new System.Drawing.Size(134, 35);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Restart(重启)";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.Transparent;
            this.btnSetting.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSetting.DownBack = null;
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(9, 137);
            this.btnSetting.MouseBack = null;
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.NormlBack = null;
            this.btnSetting.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnSetting.Size = new System.Drawing.Size(136, 35);
            this.btnSetting.TabIndex = 11;
            this.btnSetting.Text = "Setting(设置)";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.Transparent;
            this.btnQuery.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnQuery.DownBack = null;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(11, 96);
            this.btnQuery.MouseBack = null;
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.NormlBack = null;
            this.btnQuery.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnQuery.Size = new System.Drawing.Size(134, 35);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "Query(查询)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStop.DownBack = null;
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.Location = new System.Drawing.Point(11, 54);
            this.btnStop.MouseBack = null;
            this.btnStop.Name = "btnStop";
            this.btnStop.NormlBack = null;
            this.btnStop.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnStop.Size = new System.Drawing.Size(134, 35);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop(停止)";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStart.DownBack = null;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(11, 14);
            this.btnStart.MouseBack = null;
            this.btnStart.Name = "btnStart";
            this.btnStart.NormlBack = null;
            this.btnStart.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnStart.Size = new System.Drawing.Size(134, 35);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start(开始)";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // skinGroupBox4
            // 
            this.skinGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox4.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox4.Controls.Add(this.txtFPY);
            this.skinGroupBox4.Controls.Add(this.txtFail);
            this.skinGroupBox4.Controls.Add(this.txtPass);
            this.skinGroupBox4.Controls.Add(this.txtTotal);
            this.skinGroupBox4.Controls.Add(this.skinLabel5);
            this.skinGroupBox4.Controls.Add(this.skinLabel4);
            this.skinGroupBox4.Controls.Add(this.skinLabel3);
            this.skinGroupBox4.Controls.Add(this.skinLabel2);
            this.skinGroupBox4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox4.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox4.Location = new System.Drawing.Point(625, 151);
            this.skinGroupBox4.Name = "skinGroupBox4";
            this.skinGroupBox4.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox4.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox4.Size = new System.Drawing.Size(157, 143);
            this.skinGroupBox4.TabIndex = 8;
            this.skinGroupBox4.TabStop = false;
            this.skinGroupBox4.Text = "FPY";
            this.skinGroupBox4.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox4.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox4.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // txtFPY
            // 
            this.txtFPY.BackColor = System.Drawing.Color.Transparent;
            this.txtFPY.DownBack = null;
            this.txtFPY.Icon = null;
            this.txtFPY.IconIsButton = false;
            this.txtFPY.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFPY.IsPasswordChat = '\0';
            this.txtFPY.IsSystemPasswordChar = false;
            this.txtFPY.Lines = new string[] {
        "SC50F543141234567890123"};
            this.txtFPY.Location = new System.Drawing.Point(50, 105);
            this.txtFPY.Margin = new System.Windows.Forms.Padding(0);
            this.txtFPY.MaxLength = 32767;
            this.txtFPY.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtFPY.MouseBack = null;
            this.txtFPY.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFPY.Multiline = false;
            this.txtFPY.Name = "txtFPY";
            this.txtFPY.NormlBack = null;
            this.txtFPY.Padding = new System.Windows.Forms.Padding(5);
            this.txtFPY.ReadOnly = true;
            this.txtFPY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFPY.Size = new System.Drawing.Size(96, 28);
            // 
            // 
            // 
            this.txtFPY.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFPY.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFPY.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtFPY.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtFPY.SkinTxt.Name = "BaseText";
            this.txtFPY.SkinTxt.ReadOnly = true;
            this.txtFPY.SkinTxt.Size = new System.Drawing.Size(86, 18);
            this.txtFPY.SkinTxt.TabIndex = 0;
            this.txtFPY.SkinTxt.Text = "SC50F543141234567890123";
            this.txtFPY.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFPY.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFPY.SkinTxt.WaterText = "";
            this.txtFPY.TabIndex = 11;
            this.txtFPY.Text = "SC50F543141234567890123";
            this.txtFPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFPY.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFPY.WaterText = "";
            this.txtFPY.WordWrap = true;
            // 
            // txtFail
            // 
            this.txtFail.BackColor = System.Drawing.Color.Transparent;
            this.txtFail.DownBack = null;
            this.txtFail.Icon = null;
            this.txtFail.IconIsButton = false;
            this.txtFail.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFail.IsPasswordChat = '\0';
            this.txtFail.IsSystemPasswordChar = false;
            this.txtFail.Lines = new string[] {
        "SC50F543141234567890123"};
            this.txtFail.Location = new System.Drawing.Point(50, 76);
            this.txtFail.Margin = new System.Windows.Forms.Padding(0);
            this.txtFail.MaxLength = 32767;
            this.txtFail.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtFail.MouseBack = null;
            this.txtFail.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtFail.Multiline = false;
            this.txtFail.Name = "txtFail";
            this.txtFail.NormlBack = null;
            this.txtFail.Padding = new System.Windows.Forms.Padding(5);
            this.txtFail.ReadOnly = true;
            this.txtFail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFail.Size = new System.Drawing.Size(96, 28);
            // 
            // 
            // 
            this.txtFail.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFail.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFail.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtFail.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtFail.SkinTxt.Name = "BaseText";
            this.txtFail.SkinTxt.ReadOnly = true;
            this.txtFail.SkinTxt.Size = new System.Drawing.Size(86, 18);
            this.txtFail.SkinTxt.TabIndex = 0;
            this.txtFail.SkinTxt.Text = "SC50F543141234567890123";
            this.txtFail.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFail.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFail.SkinTxt.WaterText = "";
            this.txtFail.TabIndex = 10;
            this.txtFail.Text = "SC50F543141234567890123";
            this.txtFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFail.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtFail.WaterText = "";
            this.txtFail.WordWrap = true;
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Transparent;
            this.txtPass.DownBack = null;
            this.txtPass.Icon = null;
            this.txtPass.IconIsButton = false;
            this.txtPass.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPass.IsPasswordChat = '\0';
            this.txtPass.IsSystemPasswordChar = false;
            this.txtPass.Lines = new string[] {
        "SC50F543141234567890123"};
            this.txtPass.Location = new System.Drawing.Point(50, 46);
            this.txtPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtPass.MaxLength = 32767;
            this.txtPass.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtPass.MouseBack = null;
            this.txtPass.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.NormlBack = null;
            this.txtPass.Padding = new System.Windows.Forms.Padding(5);
            this.txtPass.ReadOnly = true;
            this.txtPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPass.Size = new System.Drawing.Size(96, 28);
            // 
            // 
            // 
            this.txtPass.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPass.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtPass.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtPass.SkinTxt.Name = "BaseText";
            this.txtPass.SkinTxt.ReadOnly = true;
            this.txtPass.SkinTxt.Size = new System.Drawing.Size(86, 18);
            this.txtPass.SkinTxt.TabIndex = 0;
            this.txtPass.SkinTxt.Text = "SC50F543141234567890123";
            this.txtPass.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPass.SkinTxt.WaterText = "";
            this.txtPass.TabIndex = 9;
            this.txtPass.Text = "SC50F543141234567890123";
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtPass.WaterText = "";
            this.txtPass.WordWrap = true;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Transparent;
            this.txtTotal.DownBack = null;
            this.txtTotal.Icon = null;
            this.txtTotal.IconIsButton = false;
            this.txtTotal.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTotal.IsPasswordChat = '\0';
            this.txtTotal.IsSystemPasswordChar = false;
            this.txtTotal.Lines = new string[] {
        "SC50F543141234567890123"};
            this.txtTotal.Location = new System.Drawing.Point(50, 17);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(0);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtTotal.MouseBack = null;
            this.txtTotal.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.NormlBack = null;
            this.txtTotal.Padding = new System.Windows.Forms.Padding(5);
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotal.Size = new System.Drawing.Size(96, 28);
            // 
            // 
            // 
            this.txtTotal.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtTotal.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtTotal.SkinTxt.Name = "BaseText";
            this.txtTotal.SkinTxt.ReadOnly = true;
            this.txtTotal.SkinTxt.Size = new System.Drawing.Size(86, 18);
            this.txtTotal.SkinTxt.TabIndex = 0;
            this.txtTotal.SkinTxt.Text = "SC50F543141234567890123";
            this.txtTotal.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTotal.SkinTxt.WaterText = "";
            this.txtTotal.TabIndex = 8;
            this.txtTotal.Text = "SC50F543141234567890123";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTotal.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtTotal.WaterText = "";
            this.txtTotal.WordWrap = true;
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(11, 111);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(31, 17);
            this.skinLabel5.TabIndex = 16;
            this.skinLabel5.Text = "FPY:";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(11, 84);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(30, 17);
            this.skinLabel4.TabIndex = 15;
            this.skinLabel4.Text = "Fail:";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(9, 55);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(37, 17);
            this.skinLabel3.TabIndex = 14;
            this.skinLabel3.Text = "Pass:";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(7, 24);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(40, 17);
            this.skinLabel2.TabIndex = 13;
            this.skinLabel2.Text = "Total:";
            // 
            // skinGroupBox5
            // 
            this.skinGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox5.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox5.Controls.Add(this.btnFresh);
            this.skinGroupBox5.Controls.Add(this.skinLabel1);
            this.skinGroupBox5.Controls.Add(this.comboPLC);
            this.skinGroupBox5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox5.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox5.Location = new System.Drawing.Point(625, 299);
            this.skinGroupBox5.Name = "skinGroupBox5";
            this.skinGroupBox5.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox5.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox5.Size = new System.Drawing.Size(157, 91);
            this.skinGroupBox5.TabIndex = 9;
            this.skinGroupBox5.TabStop = false;
            this.skinGroupBox5.Text = "SerialPort Setting";
            this.skinGroupBox5.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox5.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox5.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Transparent;
            this.btnFresh.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFresh.DownBack = null;
            this.btnFresh.Location = new System.Drawing.Point(10, 52);
            this.btnFresh.MouseBack = null;
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.NormlBack = null;
            this.btnFresh.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnFresh.Size = new System.Drawing.Size(136, 32);
            this.btnFresh.TabIndex = 12;
            this.btnFresh.Text = "Fresh(刷新串口)";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(7, 26);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(64, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "SerialPort";
            // 
            // comboPLC
            // 
            this.comboPLC.FormattingEnabled = true;
            this.comboPLC.Location = new System.Drawing.Point(78, 23);
            this.comboPLC.Name = "comboPLC";
            this.comboPLC.Size = new System.Drawing.Size(68, 25);
            this.comboPLC.TabIndex = 0;
            this.comboPLC.SelectedIndexChanged += new System.EventHandler(this.comboPLC_SelectedIndexChanged);
            // 
            // spPLC
            // 
            this.spPLC.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spPLC_DataReceived);
            // 
            // skinGroupBox6
            // 
            this.skinGroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox6.BorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox6.Controls.Add(this.lstStatus);
            this.skinGroupBox6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinGroupBox6.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox6.Location = new System.Drawing.Point(28, 353);
            this.skinGroupBox6.Name = "skinGroupBox6";
            this.skinGroupBox6.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox6.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox6.Size = new System.Drawing.Size(591, 258);
            this.skinGroupBox6.TabIndex = 10;
            this.skinGroupBox6.TabStop = false;
            this.skinGroupBox6.Text = "System Info List";
            this.skinGroupBox6.TitleBorderColor = System.Drawing.Color.Blue;
            this.skinGroupBox6.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox6.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // lstStatus
            // 
            this.lstStatus.Back = null;
            this.lstStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lstStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstStatus.FormattingEnabled = true;
            this.lstStatus.ItemHeight = 18;
            this.lstStatus.ItemRadius = 18;
            this.lstStatus.Location = new System.Drawing.Point(8, 25);
            this.lstStatus.Name = "lstStatus";
            this.lstStatus.Size = new System.Drawing.Size(577, 220);
            this.lstStatus.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 627);
            this.Controls.Add(this.skinGroupBox6);
            this.Controls.Add(this.skinGroupBox5);
            this.Controls.Add(this.skinGroupBox4);
            this.Controls.Add(this.skinGroupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picTitle);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.skinGroupBox1);
            this.Controls.Add(this.lblResult);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox7.ResumeLayout(false);
            this.skinGroupBox7.PerformLayout();
            this.skinGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            this.skinGroupBox3.ResumeLayout(false);
            this.skinGroupBox4.ResumeLayout(false);
            this.skinGroupBox4.PerformLayout();
            this.skinGroupBox5.ResumeLayout(false);
            this.skinGroupBox5.PerformLayout();
            this.skinGroupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinListBox lstCommand;
        private CCWin.SkinControl.SkinLabel lblResult;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private System.Windows.Forms.PictureBox picTitle;
        private System.Windows.Forms.Label label1;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox3;
        private CCWin.SkinControl.SkinButton btnSetting;
        private CCWin.SkinControl.SkinButton btnQuery;
        private CCWin.SkinControl.SkinButton btnStop;
        private CCWin.SkinControl.SkinButton btnStart;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox4;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox5;
        private CCWin.SkinControl.SkinButton btnFresh;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.ComboBox comboPLC;
        private CCWin.SkinControl.SkinButton btnRestart;
        private CCWin.SkinControl.SkinTextBox txtFPY;
        private CCWin.SkinControl.SkinTextBox txtFail;
        private CCWin.SkinControl.SkinTextBox txtPass;
        private CCWin.SkinControl.SkinTextBox txtTotal;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.IO.Ports.SerialPort spPLC;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox6;
        private CCWin.SkinControl.SkinListBox lstStatus;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox7;
        private CCWin.SkinControl.SkinListBox lstBarcode;
        private System.Windows.Forms.TextBox txtBarcode;
    }
}

