using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace MudDude1
{
    public partial class frmSettings : Form
    {
        char[] comboBoxContents = { '!', '@', '#', '$', '%', '^', '*' };

        public frmSettings()
        {
            InitializeComponent();
            ControlBox = false;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            PopulateFields();
        }

        // TODO *BUGFIX* check why this doesn't work
        private void frmSettings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Hide();
            }
        }

        private void btnSettingsOk_Click(object sender, EventArgs e)
        {
            if (SettingsSanityCheck())
            {
                SaveSettingsToDisk();
                Hide();
            }
        }

        private void btnSettingsCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void SaveSettingsToDisk()
        {
            MudDude1.Default.STRING_SERVER_IP = txtServerIP.Text;
            MudDude1.Default.INT_SERVER_PORT = int.Parse(txtServerPort.Text);
            MudDude1.Default.STRING_USERID = txtUserID.Text;
            MudDude1.Default.STRING_PASSWORD = txtPassword.Text;

            MudDude1.Default.CHAR_TRIGGER = (char)cbTrigger1.SelectedItem;
            MudDude1.Default.CHAR_TRIGGER2 = (char)cbTrigger2.SelectedItem;

            MudDude1.Default.INT_EVILPOINTS_FOR_EVIL = int.Parse(txtEPForEvil.Text);
            MudDude1.Default.INT_RECONNECT_DELAY = int.Parse(txtReconnectDelay.Text);

            MudDude1.Default.STRING_GO_COMMAND = txtGoCMD.Text;
            MudDude1.Default.STRING_LOGIN_USERNAME = txtDetectUserID.Text;
            MudDude1.Default.STRING_LOGIN_PASSWORD = txtDetectPassword.Text;
            MudDude1.Default.STRING_PAUSE_STRING = txtDetectPauseString.Text;
            MudDude1.Default.STRING_TOP_MENU = txtDetectTopMenu.Text;
            MudDude1.Default.STRING_CLEANUP = txtDetectCleanup.Text;


            if (MudDude1.Default.IS_FIRST_RUN)
                MudDude1.Default.IS_FIRST_RUN = false;
            MudDude1.Default.Save();
        }
        
        private void PopulateFields()
        {
            txtServerIP.Text = MudDude1.Default.STRING_SERVER_IP;
            txtServerPort.Text = MudDude1.Default.INT_SERVER_PORT.ToString();
            txtUserID.Text = MudDude1.Default.STRING_USERID;
            txtPassword.Text = MudDude1.Default.STRING_PASSWORD;

            cbTrigger1.Items.Clear();
            cbTrigger2.Items.Clear();

            foreach (char trig in comboBoxContents)
            {
                cbTrigger1.Items.Add(trig);
            }
            cbTrigger1.SelectedItem = MudDude1.Default.CHAR_TRIGGER;
            foreach (char trig in comboBoxContents)
            {
                cbTrigger2.Items.Add(trig);
            }
            cbTrigger2.SelectedItem = MudDude1.Default.CHAR_TRIGGER2;

            txtEPForEvil.Text = MudDude1.Default.INT_EVILPOINTS_FOR_EVIL.ToString();
            txtReconnectDelay.Text = MudDude1.Default.INT_RECONNECT_DELAY.ToString();

            txtGoCMD.Text = MudDude1.Default.STRING_GO_COMMAND;
            txtDetectUserID.Text = MudDude1.Default.STRING_LOGIN_USERNAME;
            txtDetectPassword.Text = MudDude1.Default.STRING_LOGIN_PASSWORD;
            txtDetectPauseString.Text = MudDude1.Default.STRING_PAUSE_STRING;
            txtDetectTopMenu.Text = MudDude1.Default.STRING_TOP_MENU;
            txtDetectCleanup.Text = MudDude1.Default.STRING_CLEANUP;
        }

        private bool SettingsSanityCheck()
        {
            // IP validation, false if not a valid IP or field is empty
            IPAddress ipaddr;
            if (!IPAddress.TryParse(txtServerIP.Text, out ipaddr) ||
                txtServerIP.Text == "")
            {
                MessageBox.Show("IP address must be in 0.0.0.0 format.\nDomain names are not yet supported.");
                txtServerIP.Focus();
                return false;
            }

            // !int.tryparse checks for invalid chars (IE. not numbers)
            // Port number validation, fails if not a whole number between 1 and 65535
            int tempInt;
            if (!int.TryParse(txtServerPort.Text, out tempInt) || 
                int.Parse(txtServerPort.Text) < 0 || 
                int.Parse(txtServerPort.Text) >= 65535 ||
                txtServerPort.Text == "")
            {
                MessageBox.Show("Server port must be a whole number, between 1 and 65535.\nPort 23 is the default telnet port.");
                txtServerPort.Focus();
                return false;
            }
            
            // EP validation, fails if not a whole number between 40 and 200
            if (!int.TryParse(txtEPForEvil.Text, out tempInt) ||
                int.Parse(txtEPForEvil.Text) < 40 || 
                int.Parse(txtEPForEvil.Text) > 200)
            {
                MessageBox.Show("EP For Evil should be between 40 (outlaw) and 200 (fiend)");
                txtEPForEvil.Focus();
                return false;
            }

            // reconnect delay validation, fails if not a whole number between 1 and 3600
            if (!int.TryParse(txtReconnectDelay.Text, out tempInt) ||
                int.Parse(txtReconnectDelay.Text) < 1 ||
                int.Parse(txtReconnectDelay.Text) > 1200)
            {
                MessageBox.Show("Reconnect delay should be between 1 and 3600 seconds(1 hour)");
                txtReconnectDelay.Focus();
                return false;
            }

            // Check for empty fields, that aren't checked for validity
            if (txtUserID.Text == string.Empty || txtPassword.Text == string.Empty || txtGoCMD.Text == string.Empty ||
                txtDetectUserID.Text == string.Empty || txtDetectTopMenu.Text == string.Empty || txtDetectPauseString.Text == string.Empty ||
                txtDetectPassword.Text == string.Empty || txtDetectCleanup.Text == string.Empty)
            {
                MessageBox.Show("All fields must be populated!");
                return false;
            }
            return true;
            
        }
    }
}
