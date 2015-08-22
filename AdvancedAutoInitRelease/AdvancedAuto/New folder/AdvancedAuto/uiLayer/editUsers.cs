using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using entityLayer;
using businessLayer;

namespace uiLayer
{
    public partial class editUsers : Form
    {
        user user;
        viewUsers currentView;
        Timer labelTimer;

        public editUsers(user user, viewUsers currentView)
        {
            InitializeComponent();
            this.user = user;
            this.currentView = currentView;
            labelTimer = new Timer();
            fnameVerify.Font = new Font("Calibri", 10);
            lnameVerify.Font = new Font("Calibri", 10);
            userNameVerify.Font = new Font("Calibri", 10);
            nicVerify.Font = new Font("Calibri", 10);
            roleVerify.Font = new Font("Calibri", 10);
            passwordVerify.Font = new Font("Calibri", 10);
            setData();
        }

        private void setData()
        {
            txtFname.Text = user.First_Name;
            txtLname.Text = user.Last_Name;
            userName.Text = user.Username;
            txtAddress.Text = user.Address;
            txtTel.Text = user.Telephone;
            txtNIC.Text = user.NIC;
            password.Text = user.Password;
            roleDataBindings();
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
                    user user = new user(uName, urole, uPword, uFName, uLName, uAddress, uTel, uLNic);
                    Boolean userInsertionFlag = userDataManipulations.updateUser(user);
                    if (userInsertionFlag)
                    {
                        MessageBox.Show("Update Successfull. Data Updated successfully", "Important Note",
                        MessageBoxButtons.OK);
                        currentView.bindDataTableData();
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed. Check the Updated data again", "Important Note",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    userNameVerify.Show();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
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
            role.Add(user.Role, user.Role);
            if(!(user.Role == "Admin")){
                role.Add("Admin", "Admin");
            }
            if(!(user.Role == "User")){
                role.Add("User", "User");
            }
            cmbRole.DataSource = new BindingSource(role, null);
            cmbRole.DisplayMember = "Value";
            cmbRole.ValueMember = "Key";
        }

        private void clearForm()
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtAddress.Text = "";
            txtTel.Text = "";
            txtNIC.Text = "";
            password.Text = "";
            cmbRole.Text = "";
            labelRemover();
        }
    }
}
