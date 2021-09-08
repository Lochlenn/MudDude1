
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
            this.SuspendLayout();
            // 
            // btnSettingsOk
            // 
            this.btnSettingsOk.Location = new System.Drawing.Point(312, 444);
            this.btnSettingsOk.Name = "btnSettingsOk";
            this.btnSettingsOk.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsOk.TabIndex = 14;
            this.btnSettingsOk.Text = "&OK";
            this.btnSettingsOk.UseVisualStyleBackColor = true;
            this.btnSettingsOk.Click += new System.EventHandler(this.btnSettingsOk_Click);
            // 
            // btnSettingsCancel
            // 
            this.btnSettingsCancel.Location = new System.Drawing.Point(13, 444);
            this.btnSettingsCancel.Name = "btnSettingsCancel";
            this.btnSettingsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsCancel.TabIndex = 13;
            this.btnSettingsCancel.Text = "&Cancel";
            this.btnSettingsCancel.UseVisualStyleBackColor = true;
            this.btnSettingsCancel.Click += new System.EventHandler(this.btnSettingsCancel_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(87, 22);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(100, 20);
            this.txtServerIP.TabIndex = 0;
            // 
            // lblServerIP
            // 
            this.lblServerIP.Location = new System.Drawing.Point(10, 25);
            this.lblServerIP.Name = "lblServerIP";
            this.lblServerIP.Size = new System.Drawing.Size(70, 15);
            this.lblServerIP.TabIndex = 3;
            this.lblServerIP.Text = "Server IP:";
            this.lblServerIP.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblServerPort
            // 
            this.lblServerPort.Location = new System.Drawing.Point(10, 47);
            this.lblServerPort.Name = "lblServerPort";
            this.lblServerPort.Size = new System.Drawing.Size(70, 15);
            this.lblServerPort.TabIndex = 5;
            this.lblServerPort.Text = "Server Port:";
            this.lblServerPort.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(87, 44);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.Size = new System.Drawing.Size(100, 20);
            this.txtServerPort.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(206, 48);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 15);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(283, 45);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(206, 26);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(70, 15);
            this.lblUserID.TabIndex = 7;
            this.lblUserID.Text = "UserID:";
            this.lblUserID.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(283, 23);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 2;
            // 
            // lblDetectForUserID
            // 
            this.lblDetectForUserID.AutoSize = true;
            this.lblDetectForUserID.Location = new System.Drawing.Point(10, 225);
            this.lblDetectForUserID.Name = "lblDetectForUserID";
            this.lblDetectForUserID.Size = new System.Drawing.Size(111, 13);
            this.lblDetectForUserID.TabIndex = 11;
            this.lblDetectForUserID.Text = "String to send UserID:";
            // 
            // txtDetectUserID
            // 
            this.txtDetectUserID.Location = new System.Drawing.Point(13, 239);
            this.txtDetectUserID.Name = "txtDetectUserID";
            this.txtDetectUserID.Size = new System.Drawing.Size(365, 20);
            this.txtDetectUserID.TabIndex = 8;
            // 
            // txtDetectPassword
            // 
            this.txtDetectPassword.Location = new System.Drawing.Point(13, 279);
            this.txtDetectPassword.Name = "txtDetectPassword";
            this.txtDetectPassword.Size = new System.Drawing.Size(365, 20);
            this.txtDetectPassword.TabIndex = 9;
            // 
            // lblDetectForPassword
            // 
            this.lblDetectForPassword.AutoSize = true;
            this.lblDetectForPassword.Location = new System.Drawing.Point(10, 265);
            this.lblDetectForPassword.Name = "lblDetectForPassword";
            this.lblDetectForPassword.Size = new System.Drawing.Size(123, 13);
            this.lblDetectForPassword.TabIndex = 13;
            this.lblDetectForPassword.Text = "String to send password:";
            // 
            // txtDetectPauseString
            // 
            this.txtDetectPauseString.Location = new System.Drawing.Point(13, 319);
            this.txtDetectPauseString.Name = "txtDetectPauseString";
            this.txtDetectPauseString.Size = new System.Drawing.Size(365, 20);
            this.txtDetectPauseString.TabIndex = 10;
            // 
            // lblDetectPauseString
            // 
            this.lblDetectPauseString.AutoSize = true;
            this.lblDetectPauseString.Location = new System.Drawing.Point(10, 305);
            this.lblDetectPauseString.Name = "lblDetectPauseString";
            this.lblDetectPauseString.Size = new System.Drawing.Size(70, 13);
            this.lblDetectPauseString.TabIndex = 15;
            this.lblDetectPauseString.Text = "Pause String:";
            // 
            // txtDetectTopMenu
            // 
            this.txtDetectTopMenu.Location = new System.Drawing.Point(13, 359);
            this.txtDetectTopMenu.Name = "txtDetectTopMenu";
            this.txtDetectTopMenu.Size = new System.Drawing.Size(365, 20);
            this.txtDetectTopMenu.TabIndex = 11;
            // 
            // lblDetectTopMenu
            // 
            this.lblDetectTopMenu.AutoSize = true;
            this.lblDetectTopMenu.Location = new System.Drawing.Point(10, 345);
            this.lblDetectTopMenu.Name = "lblDetectTopMenu";
            this.lblDetectTopMenu.Size = new System.Drawing.Size(89, 13);
            this.lblDetectTopMenu.TabIndex = 17;
            this.lblDetectTopMenu.Text = "Top Menu String:";
            // 
            // txtDetectCleanup
            // 
            this.txtDetectCleanup.Location = new System.Drawing.Point(13, 399);
            this.txtDetectCleanup.Name = "txtDetectCleanup";
            this.txtDetectCleanup.Size = new System.Drawing.Size(365, 20);
            this.txtDetectCleanup.TabIndex = 12;
            // 
            // lblDetectCleanup
            // 
            this.lblDetectCleanup.AutoSize = true;
            this.lblDetectCleanup.Location = new System.Drawing.Point(10, 385);
            this.lblDetectCleanup.Name = "lblDetectCleanup";
            this.lblDetectCleanup.Size = new System.Drawing.Size(135, 13);
            this.lblDetectCleanup.TabIndex = 19;
            this.lblDetectCleanup.Text = "Cleanup Notification String:";
            // 
            // gbDetectionStrings
            // 
            this.gbDetectionStrings.Location = new System.Drawing.Point(6, 202);
            this.gbDetectionStrings.Name = "gbDetectionStrings";
            this.gbDetectionStrings.Size = new System.Drawing.Size(381, 236);
            this.gbDetectionStrings.TabIndex = 21;
            this.gbDetectionStrings.TabStop = false;
            this.gbDetectionStrings.Text = "Detection Strings:";
            // 
            // lblTrigger1
            // 
            this.lblTrigger1.AutoSize = true;
            this.lblTrigger1.Location = new System.Drawing.Point(303, 86);
            this.lblTrigger1.Name = "lblTrigger1";
            this.lblTrigger1.Size = new System.Drawing.Size(43, 13);
            this.lblTrigger1.TabIndex = 22;
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
            this.cbTrigger1.Location = new System.Drawing.Point(349, 81);
            this.cbTrigger1.Name = "cbTrigger1";
            this.cbTrigger1.Size = new System.Drawing.Size(34, 21);
            this.cbTrigger1.TabIndex = 5;
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
            this.cbTrigger2.Location = new System.Drawing.Point(349, 110);
            this.cbTrigger2.Name = "cbTrigger2";
            this.cbTrigger2.Size = new System.Drawing.Size(34, 21);
            this.cbTrigger2.TabIndex = 6;
            // 
            // lblTrigger2
            // 
            this.lblTrigger2.AutoSize = true;
            this.lblTrigger2.Location = new System.Drawing.Point(264, 113);
            this.lblTrigger2.Name = "lblTrigger2";
            this.lblTrigger2.Size = new System.Drawing.Size(83, 13);
            this.lblTrigger2.TabIndex = 24;
            this.lblTrigger2.Text = "Second Trigger:";
            // 
            // lblGoCommand
            // 
            this.lblGoCommand.AutoSize = true;
            this.lblGoCommand.Location = new System.Drawing.Point(13, 141);
            this.lblGoCommand.Name = "lblGoCommand";
            this.lblGoCommand.Size = new System.Drawing.Size(217, 13);
            this.lblGoCommand.TabIndex = 26;
            this.lblGoCommand.Text = "Command to get to MajorMUD landing page:";
            // 
            // txtGoCMD
            // 
            this.txtGoCMD.Location = new System.Drawing.Point(14, 156);
            this.txtGoCMD.Name = "txtGoCMD";
            this.txtGoCMD.Size = new System.Drawing.Size(369, 20);
            this.txtGoCMD.TabIndex = 7;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 479);
            this.Controls.Add(this.txtGoCMD);
            this.Controls.Add(this.lblGoCommand);
            this.Controls.Add(this.cbTrigger2);
            this.Controls.Add(this.lblTrigger2);
            this.Controls.Add(this.cbTrigger1);
            this.Controls.Add(this.lblTrigger1);
            this.Controls.Add(this.txtDetectCleanup);
            this.Controls.Add(this.lblDetectCleanup);
            this.Controls.Add(this.txtDetectTopMenu);
            this.Controls.Add(this.lblDetectTopMenu);
            this.Controls.Add(this.txtDetectPauseString);
            this.Controls.Add(this.lblDetectPauseString);
            this.Controls.Add(this.txtDetectPassword);
            this.Controls.Add(this.lblDetectForPassword);
            this.Controls.Add(this.txtDetectUserID);
            this.Controls.Add(this.lblDetectForUserID);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.lblServerPort);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.lblServerIP);
            this.Controls.Add(this.txtServerIP);
            this.Controls.Add(this.btnSettingsCancel);
            this.Controls.Add(this.btnSettingsOk);
            this.Controls.Add(this.gbDetectionStrings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 522);
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSettings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSettings_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}