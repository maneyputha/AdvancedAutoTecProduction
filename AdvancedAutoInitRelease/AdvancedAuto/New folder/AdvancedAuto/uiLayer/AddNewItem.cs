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

namespace uiLayer
{
    public partial class AddNewItem : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(AddNewItem));
        public AddNewItem()
        {
            InitializeComponent();
            this.txtPrice.KeyPress += new KeyPressEventHandler(txtPrice_KeyPress);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if(!(txtName.Text.Equals("") || txtPrice.Equals("") || txtQuantity.Equals("")))
                {
                    String name = txtName.Text;
                    int qty = Convert.ToInt32(txtQuantity.Text);
                    decimal price = Convert.ToDecimal(txtPrice.Text);
                    if (!(price.Equals(0) || qty.Equals(0)))
                    {
                        MainMenuAdmin.addnewItemtoList(name, price, qty);
                        this.Dispose();
                    }
                    else 
                    {
                        MessageBox.Show("Enter values above 0 for items");
                    }
                }
                else
                {
                    MessageBox.Show("Entered values are invalid");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Something went wrong. \n Check entered date");
                //Console.WriteLine("UIL Error in AddNewItem.button1_Click: "+err.ToString());
                logger.Error("\n UI Error in AddNewItem.button1_Click: " + err.ToString());
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
