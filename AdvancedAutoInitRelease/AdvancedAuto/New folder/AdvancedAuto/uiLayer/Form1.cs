using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using entityLayer;
using businessLayer;

namespace uiLayer
{
    public partial class Form1 : Form
    {
        Timer labelTimer;
        appValidater appValidater;
        private static readonly ILog logger = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
            usernameVerifyMessage.Font = new Font("Calibri", 10);
            passwordVerifyMessage.Font = new Font("Calibri", 10);
            loginVerifyMessage.Font = new Font("Calibri",10);
            labelTimer = new Timer();
            this.Closing += form_Closing;
            wrapperDataBuffer.initalizeWrapper();
            appValidater = new appValidater();
            Boolean trialValidity = appValidater.appSerializer(15);
            if (!trialValidity)
            {
                txtUsrname.Enabled = false;
                txtPwrd.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String userName = ((txtUsrname.Text).Clone().ToString()).Replace(" ", string.Empty);
            String password = (txtPwrd.Text).Clone().ToString();
            Console.WriteLine("Login");
            if (userName == "" && password == "")
            {
                usernameVerifyMessage.Show();
                passwordVerifyMessage.Show();
                hideLabels();
            }
            else if (userName == "")
            {
                usernameVerifyMessage.Show();
                hideLabels();
            }
            else if (password == "")
            {
                passwordVerifyMessage.Show();
                hideLabels();
            }
            else
            {
                user User = new user(userName, "", password, null, null, null, null, null);
                userDataManipulations userDataManipulations = new userDataManipulations();
                Boolean userValidity = userDataManipulations.authenticateUser(User);

                if (userValidity)
                {
                    wrapperDataBuffer.WrapperObject.Flag = 0;
                    MainMenuAdmin newMainMenuAdmin = new MainMenuAdmin();
                    newMainMenuAdmin.Show();
                    this.Hide();
                }
                else
                {
                    loginVerifyMessage.Show();
                    hideLabels();
                }
            }
        }

        private void hideLabels()
        {
            labelTimer.Start();

            labelTimer.Interval = 5000;
            labelTimer.Tick += (s, e) =>
            {
                usernameVerifyMessage.Hide();
                passwordVerifyMessage.Hide();
                loginVerifyMessage.Hide();
                labelTimer.Stop();
            };
        }

        private static void form_Closing(object sender, CancelEventArgs e)
        {
            DialogResult formClose = MessageBox.Show("Are you sure you want to terminate application ?","Warning !!", 
                MessageBoxButtons.YesNo);
            if (formClose == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void validateSerial_Click(object sender, EventArgs e)
        {
            string serial = appSerial.Text;
            Boolean serialValidity = appValidater.verifySerial(serial);
            if (serialValidity)
            {
                appValidater.updateAppSerial(serial);
                txtUsrname.Enabled = true;
                txtPwrd.Enabled = true;
                button1.Enabled = true;
                lblserial.Visible = false;
                appSerial.Visible = false;
                validateSerial.Visible = false;
            }
            else
            {
                appSerial.Text = "";
            }
        }
    }
}
