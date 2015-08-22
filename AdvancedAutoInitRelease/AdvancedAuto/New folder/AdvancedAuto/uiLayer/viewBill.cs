using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using entityLayer;
using businessLayer;
using log4net;

namespace uiLayer
{
    public partial class viewBill : Form
    {
        private  List<billingItem> billItemsGrid = new List<billingItem>();
        private static readonly ILog logger = LogManager.GetLogger(typeof(MainMenuAdmin));
        private decimal completeTotal = 0.0m;
        public viewBill(int billID, String CustName, String custTel, String carNo, String dte, String username, String totl)
        {
            billItemsGrid = new stockDataManipulations().getBillItems(billID);
            
            InitializeComponent();
            generateGrid();
            lblBillID.Text = "" + billID;
            lblCustNme.Text = "" + CustName;
            lblCustTel.Text = "" + custTel;
            lblCarNo.Text = "" + carNo;
            lblDte.Text = "" + dte;
            ibiUsrNme.Text = "" + username;
            lblTotal.Text = "" + totl;


        }

        private void viewBill_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void generateGrid()
        {
            //int rowNo = billingGrid.RowCount;
            //int count = 0;
            //billingGrid.Rows.Clear();

            for (int i = 0; i < billItemsGrid.Count; i++)
            {
                billingGrid.Rows.Add();

                //billingGrid.Rows[i].Cells[0].Value = "YES";
                if (billItemsGrid[i]._type.Equals("Service"))
                {
                    billingGrid.Rows[i].Cells[0].Value = billItemsGrid[i].Service.Service_ID;
                    billingGrid.Rows[i].Cells[1].Value = billItemsGrid[i].Service.Service_Name;
                    billingGrid.Rows[i].Cells[2].Value = billItemsGrid[i].Service.Service_Price;
                    billingGrid.Rows[i].Cells[3].Value = billItemsGrid[i].Quantiy;
                    billingGrid.Rows[i].Cells[4].Value = billItemsGrid[i].Total;
                    completeTotal = completeTotal + billItemsGrid[i].Total;
                }
                if (billItemsGrid[i]._type.Equals("Product"))
                {
                    billingGrid.Rows[i].Cells[0].Value = billItemsGrid[i].Product.ProductCode;
                    billingGrid.Rows[i].Cells[1].Value = billItemsGrid[i].Product.ProductName;
                    billingGrid.Rows[i].Cells[2].Value = billItemsGrid[i].Product.ProductPrice;
                    billingGrid.Rows[i].Cells[3].Value = billItemsGrid[i].Quantiy;
                    billingGrid.Rows[i].Cells[4].Value = billItemsGrid[i].Total;
                    completeTotal = completeTotal + billItemsGrid[i].Total;
                }
            }
            //lblBillTotal.Text = "" + completeTotal;
        }
    }
}
