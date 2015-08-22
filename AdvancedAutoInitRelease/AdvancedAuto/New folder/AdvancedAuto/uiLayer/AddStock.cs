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
using log4net;

namespace uiLayer
{
    public partial class AddStock : Form
    {
        public static products selectedPrd = new products();
        public static int prdIndex = 0;
        private static readonly ILog logger = LogManager.GetLogger(typeof(AddStock));
        Timer labelTimer;

        public AddStock()
        {
            InitializeComponent();
            pcodeVerify.Font = new Font("Calibri", 10);
            costVerify.Font = new Font("Calibri", 10);
            labelTimer = new Timer();
            this.txtCost.KeyPress += new KeyPressEventHandler(txtCost_KeyPress);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try 
            {
                String pSrchKey = ((txtProductCode.Text).Replace(" ", string.Empty)).Clone().ToString();
                String details = ((txtDetails.Text).Replace(" ", string.Empty)).Clone().ToString();
                String quantity = ((txtQty.Text).Replace(" ", string.Empty)).Clone().ToString();
                String cost = ((txtCost.Text).Replace(" ", string.Empty)).Clone().ToString();


                if (pSrchKey == "" )
                {
                    pcodeVerify.Show();
                    hideLabelsTimer();
                }
                else if (cost == "")
                {
                    costVerify.Show();
                    hideLabelsTimer();
                }
                else
                {
                    String pDetails = (txtDetails.Text).Clone().ToString();
                    String sQty = (txtQty.Text).Clone().ToString();
                    String sCost = (txtCost.Text).Clone().ToString();
                    String srchKyWord = (txtProductCode.Text).Clone().ToString();
                    DateTime addDte = dateTimePicker1.Value;
                    List<products> prdLst = new stockDataManipulations().getProdByCode(srchKyWord);
                    if (!(prdLst.Count.Equals(0) || prdLst.ElementAt(0).ProductID.Equals(0)))
                    {
                        stock sdb1 = new stock(0, prdLst.ElementAt(0).ProductID, prdLst.ElementAt(0).ProductName, pDetails, addDte, Convert.ToInt32(sQty), Convert.ToDecimal(sCost));
                        int result = new stockDataManipulations().addNewStocks(sdb1);
                        if (result.Equals(0))
                        {
                            MessageBox.Show("Insertion Failed.Check the insert data again", "Important Note",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            MessageBox.Show("Insertion Successfull. Data saved successfully", "Important Note",
                            MessageBoxButtons.OK);
                            clearForm();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Entered product code or name is invalid", "Product not found",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
            }
            catch(Exception err){
                logger.Error("\n UIL Error in btnAddProduct_Click: "+err.ToString());
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
            pcodeVerify.Hide();
            costVerify.Hide();
        }

        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void clearForm()
        {
            txtDetails.Text = "";
            txtQty.Text = "";
            txtCost.Text = "";
            txtProductCode.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            labelRemover();
        }
    }
}
