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
    public partial class viewUsers : Form
    {
        private BindingSource gridViewData;

        public viewUsers()
        {
            InitializeComponent();
            this.gridViewData = new BindingSource();
            bindDataTableData();
            intializeFormuttons();
        }

        private void intializeFormuttons()
        {
            wrapper wrapperObj = wrapperDataBuffer.WrapperObject;
            if (wrapperObj.User1.Role == "Admin")
            {
                deleteBtn.Visible = true;
            }
        }

        private void bindDataTableData()
        {
            userDataManipulations userDataManipulations = new userDataManipulations();
            List<user> userList = userDataManipulations.getAllUsers();
            usersDataGrid.DataSource = userList;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = usersDataGrid.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                string userName = usersDataGrid.Rows[selectedIndex].Cells[0].Value.ToString();
                string role = usersDataGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                string password = usersDataGrid.Rows[selectedIndex].Cells[2].Value.ToString();
                string fName = usersDataGrid.Rows[selectedIndex].Cells[3].Value.ToString();
                string lName = usersDataGrid.Rows[selectedIndex].Cells[4].Value.ToString();
                string address = usersDataGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                string telephone = usersDataGrid.Rows[selectedIndex].Cells[6].Value.ToString();
                string nic = usersDataGrid.Rows[selectedIndex].Cells[7].Value.ToString();

                user selectedUser = new user(userName, role, password, fName, lName, address, 
                    telephone, nic);
                userDataManipulations userDataManipulations = new userDataManipulations();
                Boolean stockDeletion = userDataManipulations.deleteUser(selectedUser);

                if (stockDeletion)
                {
                    MessageBox.Show("Deletion Successfull. Data deleted successfully", "Important Note",
                    MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Deletion Failed. Error occured while deleting data", "Important Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
