using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private HelpProvider hlpProvider;
        bool isHelp = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            HelpProvider();
        }
        //Error Provider
        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                e.Cancel = true;
                txtUser.Focus();
                errorProviderUser.SetError(txtUser, "Please enter your user name!");

            }
            else
            {
                e.Cancel = false;
                errorProviderUser.SetError(txtUser, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                e.Cancel = true;
                txtPass.Focus();
                errorProviderPass.SetError(txtPass, "Please enter your Password!");
            }
            else
            {
                e.Cancel = false;
                errorProviderPass.SetError(txtPass, null);
            }
        }

        //Help Provider
        private void HelpProvider()
        {
            hlpProvider = new HelpProvider();
            hlpProvider.SetShowHelp(txtUser, true); // thiet lap gia tri cho txtUser la true
            hlpProvider.SetHelpString(txtUser, "Enter your username."); // thiet lap gia tri cho set help string

            hlpProvider.SetShowHelp(txtPass, true);
            hlpProvider.SetHelpString(txtPass, "Enter your password.".ToString());

            hlpProvider.SetShowHelp(btnLogin, true);
            hlpProvider.SetHelpString(btnLogin, "Click to login");
        }
        private void btn_Help_Click(object sender, EventArgs e)
        {
            isHelp = !isHelp;
            MaximizeBox = !isHelp;
            MinimizeBox = !isHelp;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        //Timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //Progress Bar
                progressBar1.PerformStep();
                if (progressBar1.Value == 1000)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("Login successful!", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
            }
            else
            {
                timer1.Enabled = false;
            }
        }
        private void Reset()
        {
            txtUser.Text = "";
            txtPass.Text = "";
            progressBar1.Value= 0;
        }        
    }
}