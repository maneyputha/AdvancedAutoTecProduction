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
    public partial class AddCatagory : Form
    {
        Timer labelTimer;

        public AddCatagory()
        {
            InitializeComponent();
            catnameVerify.Font = new Font("Calibri", 10);
            labelTimer = new Timer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnAddCatagory_Click(object sender, EventArgs e)
        {
            String catName = ((txtCatName.Text).Replace(" ", string.Empty)).Clone().ToString();
            if (catName == "")
            {
                catnameVerify.Show();
                hideLabelsTimer();
            }
            else
            {
                String itmCatName = (txtCatName.Text).Clone().ToString();
                String itmCatDesc = (txtCatDsc.Text).Clone().ToString();

                itemCategory itemCat = new itemCategory(-1, itmCatName, itmCatDesc);
                stockDataManipulations stockDataManipulations = new stockDataManipulations();
                Boolean catInsertion = stockDataManipulations.addNewItemCat(itemCat);
                if (catInsertion)
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
            catnameVerify.Hide();
        }

        private void clearForm()
        {
            txtCatName.Text = "";
            txtCatDsc.Text = "";
            labelRemover();
        }
    }
}
