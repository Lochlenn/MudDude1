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
            //start connection settings tab
            MudDude1.Default.STRING_SERVER_IP = txtServerIP.Text;
            MudDude1.Default.INT_SERVER_PORT = int.Parse(txtServerPort.Text);
            MudDude1.Default.STRING_USERID = txtUserID.Text;
            MudDude1.Default.STRING_PASSWORD = txtPassword.Text;

            MudDude1.Default.CHAR_TRIGGER = (char)cbTrigger1.SelectedItem;
            MudDude1.Default.CHAR_TRIGGER2 = (char)cbTrigger2.SelectedItem;

            MudDude1.Default.INT_RECONNECT_DELAY = int.Parse(txtReconnectDelay.Text);

            MudDude1.Default.STRING_GO_COMMAND = txtGoCMD.Text;
            MudDude1.Default.STRING_LOGIN_USERNAME = txtDetectUserID.Text;
            MudDude1.Default.STRING_LOGIN_PASSWORD = txtDetectPassword.Text;
            MudDude1.Default.STRING_PAUSE_STRING = txtDetectPauseString.Text;
            MudDude1.Default.STRING_TOP_MENU = txtDetectTopMenu.Text;
            MudDude1.Default.STRING_CLEANUP = txtDetectCleanup.Text; // not used yet
            //end connection settings tab

            //start alignment tab settings
            MudDude1.Default.ALLOW_SET_EVIL = chbAllowEvil.Checked;
            MudDude1.Default.ALLOW_SET_GOOD = chbAllowGood.Checked;
            MudDude1.Default.ALLOW_SET_LAWFUL = chbAllowLawful.Checked;
            MudDude1.Default.ALLOW_SET_NEUTRAL = chbAllowNeutral.Checked;
            MudDude1.Default.ALLOW_SET_UNLAWFUL = chbAllowUnlawful.Checked;
            MudDude1.Default.ALLOW_SET_SAINT = chbAllowSaint.Checked;

            // set defaults for ep unless custom selected
            MudDude1.Default.INT_EVILPOINTS_FOR_EVIL = MudDude1.Default.DEFAULT_EP_FOR_EVIL;
            MudDude1.Default.USE_CUSTOM_EP_EVIL = false;
            if (chbCustomEvil.Checked)
            {
                MudDude1.Default.INT_EVILPOINTS_FOR_EVIL = int.Parse(txtEPForEvil.Text);
                MudDude1.Default.USE_CUSTOM_EP_EVIL = true;
            }
                
            MudDude1.Default.INT_CUSTOM_EP_NEUTRAL = MudDude1.Default.DEFAULT_EP_FOR_NEUTRAL;
            MudDude1.Default.USE_CUSTOM_EP_NEUTRAL = false;
            if (chbCustomNeutral.Checked)
            {
                MudDude1.Default.INT_CUSTOM_EP_NEUTRAL = int.Parse(txtEPforNeutral.Text);
                MudDude1.Default.USE_CUSTOM_EP_NEUTRAL = true;
            }

            MudDude1.Default.INT_CUSTOM_EP_GOOD = MudDude1.Default.DEFAULT_EP_FOR_GOOD;
            MudDude1.Default.USE_CUSTOM_EP_GOOD = false;
            if (chbCustomGood.Checked)
            {
                MudDude1.Default.INT_CUSTOM_EP_GOOD = int.Parse(txtEPforGood.Text);
                MudDude1.Default.USE_CUSTOM_EP_GOOD = true;
            }
            //end alignment tab settings

            // first run check
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

            txtReconnectDelay.Text = MudDude1.Default.INT_RECONNECT_DELAY.ToString();

            txtGoCMD.Text = MudDude1.Default.STRING_GO_COMMAND;
            txtDetectUserID.Text = MudDude1.Default.STRING_LOGIN_USERNAME;
            txtDetectPassword.Text = MudDude1.Default.STRING_LOGIN_PASSWORD;
            txtDetectPauseString.Text = MudDude1.Default.STRING_PAUSE_STRING;
            txtDetectTopMenu.Text = MudDude1.Default.STRING_TOP_MENU;
            txtDetectCleanup.Text = MudDude1.Default.STRING_CLEANUP;

            // alignment settings tab
            chbAllowEvil.Checked = MudDude1.Default.ALLOW_SET_EVIL;
            chbAllowGood.Checked = MudDude1.Default.ALLOW_SET_GOOD;
            chbAllowLawful.Checked = MudDude1.Default.ALLOW_SET_LAWFUL;
            chbAllowNeutral.Checked = MudDude1.Default.ALLOW_SET_NEUTRAL;
            chbAllowUnlawful.Checked = MudDude1.Default.ALLOW_SET_UNLAWFUL;
            chbAllowSaint.Checked = MudDude1.Default.ALLOW_SET_SAINT;

            txtEPForEvil.Text = MudDude1.Default.INT_EVILPOINTS_FOR_EVIL.ToString();
            txtEPforNeutral.Text= MudDude1.Default.INT_CUSTOM_EP_NEUTRAL.ToString();
            txtEPforGood.Text = MudDude1.Default.INT_CUSTOM_EP_GOOD.ToString();

            chbCustomEvil.Checked = MudDude1.Default.USE_CUSTOM_EP_EVIL;
            chbCustomNeutral.Checked = MudDude1.Default.USE_CUSTOM_EP_NEUTRAL;
            chbCustomGood.Checked = MudDude1.Default.USE_CUSTOM_EP_GOOD;

            chbAllowAlignmentChanges.Checked = MudDude1.Default.ALLOW_ANY_ALIGNMENT_CHANGES;
        }

        private bool SettingsSanityCheck()
        {
            if (!AlignmentSanityCheck() || !ConnectionSettingsSanityCheck())
                return false;
            return true;
        }

        private bool AlignmentSanityCheck()
        {
            // check if alignment changes are enabled at all
            if (!chbAllowAlignmentChanges.Checked)
            {
                // Set Defaults here, maybe
                return true;
            }

            // EP validation, fails if not a whole number between x and y
            // invalid entries are ignored if custom value is not enabled
            int tempInt;
            if (chbCustomEvil.Checked)
            {
                if (!int.TryParse(txtEPForEvil.Text, out tempInt) ||
                    int.Parse(txtEPForEvil.Text) < 39 ||
                    int.Parse(txtEPForEvil.Text) > 200)
                {
                    MessageBox.Show("EP For Evil should be between 40 and 200");
                    txtEPForEvil.Focus();
                    return false;
                }
            }
            if (chbCustomGood.Checked)
            {
                if (!int.TryParse(txtEPforGood.Text, out tempInt) ||
                int.Parse(txtEPforGood.Text) < -200 ||
                int.Parse(txtEPforGood.Text) > -51)
                {
                    MessageBox.Show("EP For Good should be between -219 and -50");
                    txtEPforGood.Focus();
                    return false;
                }
            }
            if (chbCustomNeutral.Checked)
            {
                if (!int.TryParse(txtEPforNeutral.Text, out tempInt) ||
                    int.Parse(txtEPforNeutral.Text) < -50 ||
                    int.Parse(txtEPforNeutral.Text) > 29)
                {
                    MessageBox.Show("EP For Neutral should be between -49 and 29");
                    txtEPforNeutral.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool ConnectionSettingsSanityCheck()
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

        // these 3 functions enable/disable the editable EP box if the check is selected
        private void chbCustomEvil_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCustomEvil.Checked)
            {
                txtEPForEvil.Enabled = true;
                txtEPForEvil.Text = MudDude1.Default.DEFAULT_EP_FOR_EVIL.ToString();
                txtEPForEvil.Focus();
            }
            else
                txtEPForEvil.Enabled = false;
        }

        private void chbCustomNeutral_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCustomNeutral.Checked)
            {
                txtEPforNeutral.Enabled = true;
                txtEPforNeutral.Text = MudDude1.Default.DEFAULT_EP_FOR_NEUTRAL.ToString();
                txtEPforNeutral.Focus();
            }
            else
                txtEPforNeutral.Enabled = false;
        }

        private void chbCustomGood_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCustomGood.Checked)
            {
                txtEPforGood.Enabled = true;
                txtEPforGood.Text = MudDude1.Default.DEFAULT_EP_FOR_GOOD.ToString();
                txtEPforGood.Focus();
            }
            else
                txtEPforGood.Enabled = false;
        }

        // setup the form
        private void frmSettings_Shown(object sender, EventArgs e)
        {
            CheckAlignmentSettingBools();
            SetDefaultEPTexts();
            SetCustomAlignEnable();
        }

        private void SetCustomAlignEnable()
        {
            // disables editable boxes if not enabled in settings
            txtEPForEvil.Enabled = false;
            if (chbCustomEvil.Checked)
                {
                	txtEPForEvil.Enabled = true;
                }

            txtEPforGood.Enabled = false;
            if (chbCustomGood.Checked)
                txtEPforGood.Enabled = true;

            txtEPforNeutral.Enabled = false;
            if (chbCustomNeutral.Checked)
                txtEPforNeutral.Enabled = true;
        }

        private void SetDefaultEPTexts()
        {
            // populates the default text boxes
            txtDefaultEPforEvil.Text = MudDude1.Default.DEFAULT_EP_FOR_EVIL.ToString();
            txtDefaultEPforGood.Text = MudDude1.Default.DEFAULT_EP_FOR_GOOD.ToString();
            txtDefaultEPforNeutral.Text = MudDude1.Default.DEFAULT_EP_FOR_NEUTRAL.ToString();
        }

        private void CheckAlignmentSettingBools()
        {
            // enable/disable settings if needed
            if (chbAllowAlignmentChanges.Checked)
            {
                //SetDefaultAlignmentSettings();
                // toggleables
                chbAllowEvil.Enabled = true;
                chbAllowNeutral.Enabled = true;
                chbAllowGood.Enabled = true;
                chbAllowLawful.Enabled = true;
                chbAllowUnlawful.Enabled = true;
                chbAllowSaint.Enabled = true;

                // custom values group
                chbCustomEvil.Enabled = true;
                chbCustomNeutral.Enabled = true;
                chbCustomGood.Enabled = true;
                txtEPForEvil.Enabled = true;
                txtEPforNeutral.Enabled = true;
                txtEPforGood.Enabled = true;
                SetCustomAlignEnable();
            }

            if (!chbAllowAlignmentChanges.Checked)
            {
                // uncheck toggles
                chbAllowEvil.Checked = false;
                chbAllowNeutral.Checked = false;
                chbAllowGood.Checked = false;
                chbAllowLawful.Checked = false;
                chbAllowUnlawful.Checked = false;
                chbAllowSaint.Checked = false;

                // disable toggles
                chbAllowEvil.Enabled = false;
                chbAllowNeutral.Enabled = false;
                chbAllowGood.Enabled = false;
                chbAllowLawful.Enabled = false;
                chbAllowUnlawful.Enabled = false;
                chbAllowSaint.Enabled = false;
                

                // custom values group
                chbCustomEvil.Enabled = false;
                chbCustomNeutral.Enabled = false;
                chbCustomGood.Enabled = false;
                txtEPForEvil.Enabled = false;
                txtEPforNeutral.Enabled = false;
                txtEPforGood.Enabled = false;
                SetCustomAlignEnable();
            }
        }

        private void chbAllowAlignmentChanges_CheckedChanged(object sender, EventArgs e)
        {
            CheckAlignmentSettingBools();
        }

        private void SetDefaultAlignmentSettings()
        {
            // reset default settings
            chbAllowEvil.Checked = true;
            chbAllowNeutral.Checked = true;
            chbAllowGood.Checked = true;
            chbAllowLawful.Checked = false;
            chbAllowUnlawful.Checked = false;
            chbAllowSaint.Checked = false;

            // custom values group
            SetDefaultEPTexts();
            chbCustomEvil.Checked = false;
            chbCustomNeutral.Checked = false;
            chbCustomGood.Checked = false;
            chbAllowAlignmentChanges.Checked = true;

        }

        private void btnSetAlignDefaults_Click(object sender, EventArgs e)
        {
            SetDefaultAlignmentSettings();
        }
    }
}
