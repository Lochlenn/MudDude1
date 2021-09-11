
namespace MudDude1
{
    partial class frmSettings
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
            this.btnSettingsOk = new System.Windows.Forms.Button();
            this.btnSettingsCancel = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.lblServerIP = new System.Windows.Forms.Label();
            this.lblServerPort = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblDetectForUserID = new System.Windows.Forms.Label();
            this.txtDetectUserID = new System.Windows.Forms.TextBox();
            this.txtDetectPassword = new System.Windows.Forms.TextBox();
            this.lblDetectForPassword = new System.Windows.Forms.Label();
            this.txtDetectPauseString = new System.Windows.Forms.TextBox();
            this.lblDetectPauseString = new System.Windows.Forms.Label();
            this.txtDetectTopMenu = new System.Windows.Forms.TextBox();
            this.lblDetectTopMenu = new System.Windows.Forms.Label();
            this.txtDetectCleanup = new System.Windows.Forms.TextBox();
            this.lblDetectCleanup = new System.Windows.Forms.Label();
            this.gbDetectionStrings = new System.Windows.Forms.GroupBox();
            this.lblTrigger1 = new System.Windows.Forms.Label();
            this.cbTrigger1 = new System.Windows.Forms.ComboBox();
            this.cbTrigger2 = new System.Windows.Forms.ComboBox();
            this.lblTrigger2 = new System.Windows.Forms.Label();
            this.lblGoCommand = new System.Windows.Forms.Label();
            this.txtGoCMD = new System.Windows.Forms.TextBox();
            this.lblReconnectDelay = new System.Windows.Forms.Label();
            this.txtReconnectDelay = new System.Windows.Forms.TextBox();
            this.lblReconnectDelaySeconds = new System.Windows.Forms.Label();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tabConSettings = new System.Windows.Forms.TabPage();
            this.tabAlignSettings = new System.Windows.Forms.TabPage();
            this.tabOptionalSettings = new System.Windows.Forms.TabPage();
            this.txtEPForEvil = new System.Windows.Forms.TextBox();
            this.lblEPForEvil = new System.Windows.Forms.Label();
            this.chbAllowEvil = new System.Windows.Forms.CheckBox();
            this.chbAllowNeutral = new System.Windows.Forms.CheckBox();
            this.chbAllowGood = new System.Windows.Forms.CheckBox();
            this.chbAllowLawful = new System.Windows.Forms.CheckBox();
            this.chbAllowUnlawful = new System.Windows.Forms.CheckBox();
            this.chbAllowSaint = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabSettings.SuspendLayout();
            this.tabConSettings.SuspendLayout();
            this.tabAlignSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettingsOk
            // 
            this.btnSettingsOk.Location = new System.Drawing.Point(336, 497);
            this.btnSettingsOk.Name = "btnSettingsOk";
            this.btnSettingsOk.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOk.TabIndex = 15;
            this.btnSettingsOk.Text = "&OK";
            this.btnSettingsOk.UseVisualStyleBackColor = true;
            this.btnSettingsOk.Click += new System.EventHandler(this.btnSettingsOk_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(37, 497);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 14;
            this.btnSettingsCancel.Text = "&Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(95, 14);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 0;
            // 
            // lblServerIP
            // 
            this.lblServerIP.Location = new System.Drawing.Point(18, 17);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(70, 15);
            this.lblServerIP.TabIndex = 99;
            this.lblServerIP.Text = "Server IP:";
            this.lblServerIP.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblServerPort
            // 
            this.lblServerPort.Location = new System.Drawing.Point(18, 39);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(70, 15);
            this.lblServerPort.TabIndex = 99;
            this.lblServerPort.Text = "Server Port:";
            this.lblServerPort.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(95, 36);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(214, 40);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 15);
            this.lblPassword.TabIndex = 99;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(291, 37);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(214, 18);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(70, 15);
            this.lblUserID.TabIndex = 99;
            this.lblUserID.Text = "UserID:";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(291, 15);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 2;
            // 
            // lblDetectForUserID
            // 
            this.lblDetectForUserID.AutoSize = true;
            this.lblDetectForUserID.Location = new System.Drawing.Point(18, 217);
            this.lblDetectForUserID.Name = "lblDetectForUserID";
            this.lblDetectForUserID.Size = new System.Drawing.Size(111, 13);
            this.lblDetectForUserID.TabIndex = 99;
            this.lblDetectForUserID.Text = "String to send UserID:";
            // 
            // txtDetectUserID
            // 
            this.txtDetectUserID.Location = new System.Drawing.Point(21, 231);
            this.txtDetectUserID.Name = "txtDetectUserID";
            this.txtDetectUserID.Size = new System.Drawing.Size(365, 20);
            this.txtDetectUserID.TabIndex = 9;
            // 
            // txtDetectPassword
            // 
            this.txtDetectPassword.Location = new System.Drawing.Point(21, 271);
            this.txtDetectPassword.Name = "txtDetectPassword";
            this.txtDetectPassword.Size = new System.Drawing.Size(365, 20);
            this.txtDetectPassword.TabIndex = 10;
            // 
            // lblDetectForPassword
            // 
            this.lblDetectForPassword.AutoSize = true;
            this.lblDetectForPassword.Location = new System.Drawing.Point(18, 257);
            this.lblDetectForPassword.Name = "lblDetectForPassword";
            this.lblDetectForPassword.Size = new System.Drawing.Size(123, 13);
            this.lblDetectForPassword.TabIndex = 99;
            this.lblDetectForPassword.Text = "String to send password:";
            // 
            // txtDetectPauseString
            // 
            this.txtDetectPauseString.Location = new System.Drawing.Point(21, 311);
            this.txtDetectPauseString.Name = "txtDetectPauseString";
            this.txtDetectPauseString.Size = new System.Drawing.Size(365, 20);
            this.txtDetectPauseString.TabIndex = 11;
            // 
            // lblDetectPauseString
            // 
            this.lblDetectPauseString.AutoSize = true;
            this.lblDetectPauseString.Location = new System.Drawing.Point(18, 297);
            this.lblDetectPauseString.Name = "lblDetectPauseString";
            this.lblDetectPauseString.Size = new System.Drawing.Size(70, 13);
            this.lblDetectPauseString.TabIndex = 99;
            this.lblDetectPauseString.Text = "Pause String:";
            // 
            // txtDetectTopMenu
            // 
            this.txtDetectTopMenu.Location = new System.Drawing.Point(21, 351);
            this.txtDetectTopMenu.Name = "txtDetectTopMenu";
            this.txtDetectTopMenu.Size = new System.Drawing.Size(365, 20);
            this.txtDetectTopMenu.TabIndex = 12;
            // 
            // lblDetectTopMenu
            // 
            this.lblDetectTopMenu.AutoSize = true;
            this.lblDetectTopMenu.Location = new System.Drawing.Point(18, 337);
            this.lblDetectTopMenu.Name = "lblDetectTopMenu";
            this.lblDetectTopMenu.Size = new System.Drawing.Size(89, 13);
            this.lblDetectTopMenu.TabIndex = 99;
            this.lblDetectTopMenu.Text = "Top Menu String:";
            // 
            // txtDetectCleanup
            // 
            this.txtDetectCleanup.Location = new System.Drawing.Point(21, 391);
            this.txtDetectCleanup.Name = "txtDetectCleanup";
            this.txtDetectCleanup.Size = new System.Drawing.Size(365, 20);
            this.txtDetectCleanup.TabIndex = 13;
            // 
            // lblDetectCleanup
            // 
            this.lblDetectCleanup.AutoSize = true;
            this.lblDetectCleanup.Location = new System.Drawing.Point(18, 377);
            this.lblDetectCleanup.Name = "lblDetectCleanup";
            this.lblDetectCleanup.Size = new System.Drawing.Size(135, 13);
            this.lblDetectCleanup.TabIndex = 99;
            this.lblDetectCleanup.Text = "Cleanup Notification String:";
            // 
            // gbDetectionStrings
            // 
            this.gbDetectionStrings.Location = new System.Drawing.Point(14, 194);
            this.gbDetectionStrings.Name = "gbDetectionStrings";
            this.gbDetectionStrings.Size = new System.Drawing.Size(381, 236);
            this.gbDetectionStrings.TabIndex = 21;
            this.gbDetectionStrings.TabStop = false;
            this.gbDetectionStrings.Text = "Detection Strings:";
            // 
            // lblTrigger1
            // 
            this.lblTrigger1.AutoSize = true;
            this.lblTrigger1.Location = new System.Drawing.Point(311, 78);
            this.lblTrigger1.Name = "lblTrigger1";
            this.lblTrigger1.Size = new System.Drawing.Size(43, 13);
            this.lblTrigger1.TabIndex = 99;
            this.lblTrigger1.Text = "Trigger:";
            // 
            // cbTrigger1
            // 
            this.cbTrigger1.FormattingEnabled = true;
            this.cbTrigger1.Items.AddRange(new object[] {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "*"});
            this.cbTrigger1.Location = new System.Drawing.Point(357, 73);
            this.cbTrigger1.Name = "cbTrigger1";
            this.cbTrigger1.Size = new System.Drawing.Size(34, 21);
            this.cbTrigger1.TabIndex = 6;
            // 
            // cbTrigger2
            // 
            this.cbTrigger2.FormattingEnabled = true;
            this.cbTrigger2.Items.AddRange(new object[] {
            "!",
            "@",
            "#",
            "$",
            "%",
            "^",
            "*"});
            this.cbTrigger2.Location = new System.Drawing.Point(357, 102);
            this.cbTrigger2.Name = "cbTrigger2";
            this.cbTrigger2.Size = new System.Drawing.Size(34, 21);
            this.cbTrigger2.TabIndex = 7;
            // 
            // lblTrigger2
            // 
            this.lblTrigger2.AutoSize = true;
            this.lblTrigger2.Location = new System.Drawing.Point(272, 105);
            this.lblTrigger2.Name = "lblTrigger2";
            this.lblTrigger2.Size = new System.Drawing.Size(83, 13);
            this.lblTrigger2.TabIndex = 99;
            this.lblTrigger2.Text = "Second Trigger:";
            // 
            // lblGoCommand
            // 
            this.lblGoCommand.AutoSize = true;
            this.lblGoCommand.Location = new System.Drawing.Point(21, 143);
            this.lblGoCommand.Name = "lblGoCommand";
            this.lblGoCommand.Size = new System.Drawing.Size(217, 13);
            this.lblGoCommand.TabIndex = 26;
            this.lblGoCommand.Text = "Command to get to MajorMUD landing page:";
            // 
            // txtGoCMD
            // 
            this.txtGoCMD.Location = new System.Drawing.Point(22, 158);
            this.txtGoCMD.Name = "txtGoCMD";
            this.txtGoCMD.Size = new System.Drawing.Size(369, 20);
            this.txtGoCMD.TabIndex = 8;
            // 
            // lblReconnectDelay
            // 
            this.lblReconnectDelay.AutoSize = true;
            this.lblReconnectDelay.Location = new System.Drawing.Point(26, 108);
            this.lblReconnectDelay.Name = "lblReconnectDelay";
            this.lblReconnectDelay.Size = new System.Drawing.Size(93, 13);
            this.lblReconnectDelay.TabIndex = 99;
            this.lblReconnectDelay.Text = "Reconnect Delay:";
            // 
            // txtReconnectDelay
            // 
            this.txtReconnectDelay.Location = new System.Drawing.Point(125, 103);
            this.txtReconnectDelay.Name = "txtReconnectDelay";
            this.txtReconnectDelay.Size = new System.Drawing.Size(69, 20);
            this.txtReconnectDelay.TabIndex = 5;
            // 
            // lblReconnectDelaySeconds
            // 
            this.lblReconnectDelaySeconds.AutoSize = true;
            this.lblReconnectDelaySeconds.Location = new System.Drawing.Point(196, 107);
            this.lblReconnectDelaySeconds.Name = "lblReconnectDelaySeconds";
            this.lblReconnectDelaySeconds.Size = new System.Drawing.Size(47, 13);
            this.lblReconnectDelaySeconds.TabIndex = 99;
            this.lblReconnectDelaySeconds.Text = "seconds";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabConSettings);
            this.tabSettings.Controls.Add(this.tabEvents);
            this.tabSettings.Controls.Add(this.tabAlignSettings);
            this.tabSettings.Controls.Add(this.tabOptionalSettings);
            this.tabSettings.Location = new System.Drawing.Point(3, 3);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(437, 488);
            this.tabSettings.TabIndex = 100;
            // 
            // tabEvents
            // 
            this.tabEvents.BackColor = System.Drawing.SystemColors.Control;
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(416, 453);
            this.tabEvents.TabIndex = 0;
            this.tabEvents.Text = "Events";
            // 
            // tabConSettings
            // 
            this.tabConSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabConSettings.Controls.Add(this.txtGoCMD);
            this.tabConSettings.Controls.Add(this.lblReconnectDelaySeconds);
            this.tabConSettings.Controls.Add(this.txtReconnectDelay);
            this.tabConSettings.Controls.Add(this.lblReconnectDelay);
            this.tabConSettings.Controls.Add(this.txtServerIP);
            this.tabConSettings.Controls.Add(this.lblServerIP);
            this.tabConSettings.Controls.Add(this.txtServerPort);
            this.tabConSettings.Controls.Add(this.lblGoCommand);
            this.tabConSettings.Controls.Add(this.lblServerPort);
            this.tabConSettings.Controls.Add(this.cbTrigger2);
            this.tabConSettings.Controls.Add(this.txtUserID);
            this.tabConSettings.Controls.Add(this.lblTrigger2);
            this.tabConSettings.Controls.Add(this.lblUserID);
            this.tabConSettings.Controls.Add(this.cbTrigger1);
            this.tabConSettings.Controls.Add(this.txtPassword);
            this.tabConSettings.Controls.Add(this.lblTrigger1);
            this.tabConSettings.Controls.Add(this.lblPassword);
            this.tabConSettings.Controls.Add(this.txtDetectCleanup);
            this.tabConSettings.Controls.Add(this.lblDetectForUserID);
            this.tabConSettings.Controls.Add(this.lblDetectCleanup);
            this.tabConSettings.Controls.Add(this.txtDetectUserID);
            this.tabConSettings.Controls.Add(this.txtDetectTopMenu);
            this.tabConSettings.Controls.Add(this.lblDetectForPassword);
            this.tabConSettings.Controls.Add(this.lblDetectTopMenu);
            this.tabConSettings.Controls.Add(this.txtDetectPassword);
            this.tabConSettings.Controls.Add(this.txtDetectPauseString);
            this.tabConSettings.Controls.Add(this.lblDetectPauseString);
            this.tabConSettings.Controls.Add(this.gbDetectionStrings);
            this.tabConSettings.Location = new System.Drawing.Point(4, 22);
            this.tabConSettings.Name = "tabConSettings";
            this.tabConSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabConSettings.Size = new System.Drawing.Size(429, 462);
            this.tabConSettings.TabIndex = 1;
            this.tabConSettings.Text = "Connection Settings";
            // 
            // tabAlignSettings
            // 
            this.tabAlignSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabAlignSettings.Controls.Add(this.groupBox2);
            this.tabAlignSettings.Controls.Add(this.groupBox1);
            this.tabAlignSettings.Location = new System.Drawing.Point(4, 22);
            this.tabAlignSettings.Name = "tabAlignSettings";
            this.tabAlignSettings.Size = new System.Drawing.Size(429, 462);
            this.tabAlignSettings.TabIndex = 2;
            this.tabAlignSettings.Text = "Alignment Settings";
            // 
            // tabOptionalSettings
            // 
            this.tabOptionalSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tabOptionalSettings.Location = new System.Drawing.Point(4, 22);
            this.tabOptionalSettings.Name = "tabOptionalSettings";
            this.tabOptionalSettings.Size = new System.Drawing.Size(416, 453);
            this.tabOptionalSettings.TabIndex = 3;
            this.tabOptionalSettings.Text = "Optional";
            // 
            // txtEPForEvil
            // 
            this.txtEPForEvil.Location = new System.Drawing.Point(135, 51);
            this.txtEPForEvil.Name = "txtEPForEvil";
            this.txtEPForEvil.Size = new System.Drawing.Size(43, 20);
            this.txtEPForEvil.TabIndex = 100;
            // 
            // lblEPForEvil
            // 
            this.lblEPForEvil.AutoSize = true;
            this.lblEPForEvil.Location = new System.Drawing.Point(47, 54);
            this.lblEPForEvil.Name = "lblEPForEvil";
            this.lblEPForEvil.Size = new System.Drawing.Size(69, 13);
            this.lblEPForEvil.TabIndex = 101;
            this.lblEPForEvil.Text = "EP for @evil:";
            // 
            // chbAllowEvil
            // 
            this.chbAllowEvil.AutoSize = true;
            this.chbAllowEvil.Location = new System.Drawing.Point(6, 19);
            this.chbAllowEvil.Name = "chbAllowEvil";
            this.chbAllowEvil.Size = new System.Drawing.Size(77, 17);
            this.chbAllowEvil.TabIndex = 103;
            this.chbAllowEvil.Text = "Allow Evil?";
            this.chbAllowEvil.UseVisualStyleBackColor = true;
            // 
            // chbAllowNeutral
            // 
            this.chbAllowNeutral.AutoSize = true;
            this.chbAllowNeutral.Location = new System.Drawing.Point(6, 42);
            this.chbAllowNeutral.Name = "chbAllowNeutral";
            this.chbAllowNeutral.Size = new System.Drawing.Size(94, 17);
            this.chbAllowNeutral.TabIndex = 104;
            this.chbAllowNeutral.Text = "Allow Neutral?";
            this.chbAllowNeutral.UseVisualStyleBackColor = true;
            // 
            // chbAllowGood
            // 
            this.chbAllowGood.AutoSize = true;
            this.chbAllowGood.Location = new System.Drawing.Point(6, 65);
            this.chbAllowGood.Name = "chbAllowGood";
            this.chbAllowGood.Size = new System.Drawing.Size(86, 17);
            this.chbAllowGood.TabIndex = 105;
            this.chbAllowGood.Text = "Allow Good?";
            this.chbAllowGood.UseVisualStyleBackColor = true;
            // 
            // chbAllowLawful
            // 
            this.chbAllowLawful.AutoSize = true;
            this.chbAllowLawful.Location = new System.Drawing.Point(6, 88);
            this.chbAllowLawful.Name = "chbAllowLawful";
            this.chbAllowLawful.Size = new System.Drawing.Size(91, 17);
            this.chbAllowLawful.TabIndex = 106;
            this.chbAllowLawful.Text = "Allow Lawful?";
            this.chbAllowLawful.UseVisualStyleBackColor = true;
            // 
            // chbAllowUnlawful
            // 
            this.chbAllowUnlawful.AutoSize = true;
            this.chbAllowUnlawful.Location = new System.Drawing.Point(6, 111);
            this.chbAllowUnlawful.Name = "chbAllowUnlawful";
            this.chbAllowUnlawful.Size = new System.Drawing.Size(101, 17);
            this.chbAllowUnlawful.TabIndex = 107;
            this.chbAllowUnlawful.Text = "Allow Unlawful?";
            this.chbAllowUnlawful.UseVisualStyleBackColor = true;
            // 
            // chbAllowSaint
            // 
            this.chbAllowSaint.AutoSize = true;
            this.chbAllowSaint.Location = new System.Drawing.Point(6, 134);
            this.chbAllowSaint.Name = "chbAllowSaint";
            this.chbAllowSaint.Size = new System.Drawing.Size(84, 17);
            this.chbAllowSaint.TabIndex = 108;
            this.chbAllowSaint.Text = "Allow Saint?";
            this.chbAllowSaint.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chbAllowEvil);
            this.groupBox1.Controls.Add(this.chbAllowSaint);
            this.groupBox1.Controls.Add(this.chbAllowNeutral);
            this.groupBox1.Controls.Add(this.chbAllowUnlawful);
            this.groupBox1.Controls.Add(this.chbAllowGood);
            this.groupBox1.Controls.Add(this.chbAllowLawful);
            this.groupBox1.Location = new System.Drawing.Point(20, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 165);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toggleables";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 111;
            this.label1.Text = "EP for @neutral:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 112;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 113;
            this.label2.Text = "EP for @good:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.lblEPForEvil);
            this.groupBox2.Controls.Add(this.txtEPForEvil);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(153, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 123);
            this.groupBox2.TabIndex = 114;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custom Values";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 114;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(13, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 115;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(13, 100);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 116;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(440, 530);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.btnSettingsOk);
            this.Controls.Add(this.btnSettingsCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 522);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSettings_KeyPress);
            this.tabSettings.ResumeLayout(false);
            this.tabConSettings.ResumeLayout(false);
            this.tabConSettings.PerformLayout();
            this.tabAlignSettings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSettingsOk;
        private System.Windows.Forms.Button btnSettingsCancel;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label lblServerIP;
        private System.Windows.Forms.Label lblServerPort;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label lblDetectForUserID;
        private System.Windows.Forms.TextBox txtDetectUserID;
        private System.Windows.Forms.TextBox txtDetectPassword;
        private System.Windows.Forms.Label lblDetectForPassword;
        private System.Windows.Forms.TextBox txtDetectPauseString;
        private System.Windows.Forms.Label lblDetectPauseString;
        private System.Windows.Forms.TextBox txtDetectTopMenu;
        private System.Windows.Forms.Label lblDetectTopMenu;
        private System.Windows.Forms.TextBox txtDetectCleanup;
        private System.Windows.Forms.Label lblDetectCleanup;
        private System.Windows.Forms.GroupBox gbDetectionStrings;
        private System.Windows.Forms.Label lblTrigger1;
        private System.Windows.Forms.ComboBox cbTrigger1;
        private System.Windows.Forms.ComboBox cbTrigger2;
        private System.Windows.Forms.Label lblTrigger2;
        private System.Windows.Forms.Label lblGoCommand;
        private System.Windows.Forms.TextBox txtGoCMD;
        private System.Windows.Forms.Label lblReconnectDelay;
        private System.Windows.Forms.TextBox txtReconnectDelay;
        private System.Windows.Forms.Label lblReconnectDelaySeconds;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabConSettings;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabAlignSettings;
        private System.Windows.Forms.TextBox txtEPForEvil;
        private System.Windows.Forms.Label lblEPForEvil;
        private System.Windows.Forms.TabPage tabOptionalSettings;
        private System.Windows.Forms.CheckBox chbAllowSaint;
        private System.Windows.Forms.CheckBox chbAllowUnlawful;
        private System.Windows.Forms.CheckBox chbAllowLawful;
        private System.Windows.Forms.CheckBox chbAllowGood;
        private System.Windows.Forms.CheckBox chbAllowNeutral;
        private System.Windows.Forms.CheckBox chbAllowEvil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}