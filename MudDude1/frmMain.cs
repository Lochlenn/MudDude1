using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidlandSocketServer;
using System.Windows.Forms;

namespace MudDude1
{
    public partial class frmMain : Form
    {
        frmSettings settings;
        Parser mParser;

        public frmMain()
        {
            InitializeComponent();
            
            settings = new frmSettings();
            mParser = new Parser();
            mParser.RaiseUpdateOutputEvent += UpdateOutput;
            mParser.RaiseUpdateUIEvent += UpdateUI;

            lblConnected.Hide();
            lblLoggedIn.Hide();
            lblInGame.Hide();
        }

        private void editSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (settings != null)
                settings.Show();
            else
            {
                settings = new frmSettings();
                settings.Show();
            }
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            // check/show settings form if first time running application
            if (MudDude1.Default.IS_FIRST_RUN)
            {
                settings.Show();
                settings.BringToFront();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            mParser.TryConnect();
        }

        // adds received lines to output window
        protected virtual void UpdateOutput(object sender, UpdateOutputEventArgs uoea)
        {
            try
            {
                if (rtbOutput.InvokeRequired)
                {
                    rtbOutput.Invoke(new Action(() => rtbOutput.AppendText(uoea.TextToAdd)));
                    rtbOutput.Invoke(new Action(() =>rtbOutput.ScrollToCaret()));
                }
                else
                {
                    rtbOutput.AppendText(uoea.TextToAdd);
                    rtbOutput.ScrollToCaret();
                }
                
            }
            catch (System.Exception ex)
            {

            }
        }

        protected virtual void UpdateUI(object sender, UpdateUIEventArgs uuea)
        {
            if (uuea.IsConnectedToServer)
            {
                if (lblConnected.InvokeRequired)
                    lblConnected.Invoke(new Action(() => lblConnected.Show()));
                else
                    lblConnected.Show();
            }
            else
            {
                if (lblConnected.InvokeRequired)
                    lblConnected.Invoke(new Action(() => lblConnected.Hide()));
                else
                    lblConnected.Hide();
            }
            if (uuea.IsLoggedInToServer)
            {
                if (lblLoggedIn.InvokeRequired)
                    lblLoggedIn.Invoke(new Action(() => lblLoggedIn.Show()));
                else
                    lblLoggedIn.Show();
            }
            else
            {
                if (lblLoggedIn.InvokeRequired)
                    lblLoggedIn.Invoke(new Action(() => lblLoggedIn.Hide()));
                else
                    lblLoggedIn.Hide();
            }
            if (uuea.IsInGameOnServer)
            {
                if (lblInGame.InvokeRequired)
                    lblInGame.Invoke(new Action(() => lblInGame.Show()));
                else
                    lblInGame.Show();
            }
            else
            {
                if (lblInGame.InvokeRequired)
                    lblInGame.Invoke(new Action(() => lblInGame.Hide()));
                else
                    lblInGame.Hide();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            mParser.SendConsoleCommand(txtConsoleCommand.Text);
            txtConsoleCommand.Clear();
            txtConsoleCommand.Focus();
        }

        // send contents of input box to host when enter is pressed while txtConsoleCommand has focus
        private void txtConsoleCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                mParser.SendConsoleCommand(txtConsoleCommand.Text);
                txtConsoleCommand.Clear();
                txtConsoleCommand.Focus();
                e.Handled = true;
            }
        }
    }
}
