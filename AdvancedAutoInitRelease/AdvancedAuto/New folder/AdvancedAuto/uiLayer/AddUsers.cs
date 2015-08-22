using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using entityLayer;
using businessLayer;

namespace uiLayer
{
    public partial class AddUsers : Form
    {
        Timer labelTimer;

        public AddUsers()
        {
            InitializeComponent();
            labelTimer = new Timer();
            roleDataBindings();
            fnameVerify.Font = new Font("Calibri", 10);
            lnameVerify.Font = new Font("Calibri", 10);
            userNameVerify.Font = new Font("Calibri", 10);
            nicVerify.Font = new Font("Calibri", 10);
            roleVerify.Font = new Font("Calibri", 10);
            passwordVerify.Font = new Font("Calibri", 10);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            String fName = ((txtFname.Text).Replace(" ", string.Empty)).Clone().ToString();
            String lName = ((txtLname.Text).Replace(" ", string.Empty)).Clone().ToString();
            String nic = ((txtNIC.Text).Replace(" ", string.Empty)).Clone().ToString();
            String role = ((cmbRole.Text).Replace(" ", string.Empty)).Clone().ToString();
            String usName = ((userName.Text).Replace(" ", string.Empty)).Clone().ToString();

            if (fName == "")
            {
                fnameVerify.Show();
                hideLabelsTimer();
            }
            else if (lName == "")
            {
                lnameVerify.Show();
                hideLabelsTimer();
            }
            else if (usName == "")
            {
                userNameVerify.Show();
                hideLabelsTimer();
            }
            else if (nic == "")
            {
                nicVerify.Show();
                hideLabelsTimer();
            }
            else if (role == "")
            {
                roleVerify.Show();
                hideLabelsTimer();
            }
            else if (password.Text == "")
            {
                passwordVerify.Show();
                hideLabelsTimer();
            }
            else
            {
                String uName = (userName.Text).Clone().ToString();
                String urole = ((KeyValuePair<String, String>)cmbRole.SelectedItem).Key;
                String uPword = (password.Text).Clone().ToString();
                String uFName = (txtFname.Text).Clone().ToString();
                String uLName = (txtLname.Text).Clone().ToString();
                String uAddress = (txtAddress.Text).Clone().ToString();
                String uTel = (txtTel.Text).Clone().ToString();
                String uLNic = (txtNIC.Text).Clone().ToString();
                userDataManipulations userDataManipulations = new userDataManipulations();
                if ((userDataManipulations.validateUserName(uName)))
                {
                    user newUser = new user(uName, urole, uPword, uFName, uLName, uAddress, uTel, uLNic);
                    Boolean userInsertionFlag = userDataManipulations.addNewUser(newUser);
                    if (userInsertionFlag)
                    {
                        MessageBox.Show("Insertion Successfull. Data saved successfully", "Important Note",
                        MessageBoxButtons.OK);
                        clearForm();
                    }
                    else
                    {
                        MessageBox.Show("Insertion Failed.Check the insert data again", "Important Note",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    userNameVerify.Show();
                }
              
            }

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
        }

        private void hideLabelsTimer()
        {
            labelTimer.Start();

            labelTimer.Interval = 5000;
            labelTimer.Tick += (s, e) =>
            {
                labelRemover();
                labelTimer.Stop();
            };
        }

        private void labelRemover()
        {
            fnameVerify.Hide();
            lnameVerify.Hide();
            nicVerify.Hide();
            roleVerify.Hide();
            passwordVerify.Hide();
            userNameVerify.Hide();
        }

        private void roleDataBindings()
        {
            Dictionary<string, string> role = new Dictionary<string, string>();
            role.Add("Admin", "Admin");
            role.Add("User", "User");
            cmbRole.DataSource = new BindingSource(role, null);
            cmbRole.DisplayMember = "Value";
            cmbRole.ValueMember = "Key";
        }

        private void clearForm()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            userName.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtNIC.Text = "";
            password.Text = "";
            cmbRole.Text = "";
            labelRemover();
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void fnameVerify_Click(object sender, EventArgs e)
        {

        }

        private void lnameVerify_Click(object sender, EventArgs e)
        {

        }

        private void nicVerify_Click(object sender, EventArgs e)
        {

        }

        private void passwordVerify_Click(object sender, EventArgs e)
        {

        }

        private void roleVerify_Click(object sender, EventArgs e)
        {

        }

        private void userNameVerify_Click(object sender, EventArgs e)
        {

        }
    }
}
