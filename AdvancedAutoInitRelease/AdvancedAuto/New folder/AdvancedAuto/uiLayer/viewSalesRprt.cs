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
    public partial class viewSalesRprt : Form
    {
        private BindingSource gridViewData;
        private static readonly ILog logger = LogManager.GetLogger(typeof(viewSalesRprt));
        public viewSalesRprt()
        {
            InitializeComponent();
            this.gridViewData = new BindingSource();
            bindSearchDropDown();
            searchBox.Enabled = false;
        }

        private void bindSearchDropDown()
        {
            Dictionary<int, string> searchDropDown = new Dictionary<int, string>();
            searchDropDown.Add(1, "Date");
            cmbSrchBy.DataSource = new BindingSource(searchDropDown, null);
            cmbSrchBy.DisplayMember = "Value";
            cmbSrchBy.ValueMember = "Key";
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = datetPkrFrm.Value;
            DateTime endDate = dateTPkrTo.Value;

            stockDataManipulations stockDataManipulations = new stockDataManipulations();
            List<bill> salesReport = stockDataManipulations.generateSalesReportWithin(startDate, endDate);
            salesReportGrid.DataSource = salesReport;
            totalPricelbl.Text = calculateTotal(salesReport);
        }

        private String calculateTotal(List<bill> salesReport)
        {
            decimal total = 0;
            foreach (bill entry in salesReport)
            {
                total += entry.Total;
            }
            return total.ToString();
        }

        private void cmbSrchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            int searchType = ((KeyValuePair<int, string>)cmbSrchBy.SelectedItem).Key;
            if (searchType == 1)
            {
                datetPkrFrm.Enabled = true;
                dateTPkrTo.Enabled = true;
                searchBox.Enabled = false;
            }
            else if (searchType == 2)
            {
                datetPkrFrm.Enabled = false;
                dateTPkrTo.Enabled = false;
                searchBox.Enabled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            salesReportGrid.DataSource = null;
        }

        private void viewBillBtn_Click(object sender, EventArgs e)
        {
            try {
                int selectedIndex = salesReportGrid.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    int billID = Convert.ToInt32(salesReportGrid.Rows[selectedIndex].Cells[0].Value.ToString());
                    String CustName = "" + salesReportGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                    String custTel = "" + salesReportGrid.Rows[selectedIndex].Cells[2].Value.ToString();
                    String carNo = "" + salesReportGrid.Rows[selectedIndex].Cells[3].Value.ToString();
                    String dte= "" + salesReportGrid.Rows[selectedIndex].Cells[4].Value.ToString();
                    String username = "" + salesReportGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                    String total = "" + salesReportGrid.Rows[selectedIndex].Cells[6].Value.ToString();
                    new viewBill(billID, CustName, custTel, carNo, dte, username, total).Show();
                }

            }
            catch(Exception err)
            {
                Console.WriteLine("UI Error in removeGridItem_Click: " + err.ToString());
                logger.Error("UI Error in removeGridItem_Click: " + err.ToString());
            }
        }

        private void deleteBillBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                int selectedIndex = salesReportGrid.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    string billID = salesReportGrid.Rows[selectedIndex].Cells[0].Value.ToString();
                    string customerName = salesReportGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                    string customerTel = salesReportGrid.Rows[selectedIndex].Cells[2].Value.ToString();
                    string vehicleNo = salesReportGrid.Rows[selectedIndex].Cells[3].Value.ToString();
                    string date = salesReportGrid.Rows[selectedIndex].Cells[4].Value.ToString();
                    string userName = salesReportGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                    string total = salesReportGrid.Rows[selectedIndex].Cells[6].Value.ToString();

                    bill selectedBill = new bill(Int32.Parse(billID), customerName, customerTel, vehicleNo,
                        Convert.ToDateTime(date), userName, null, Convert.ToDecimal(total));

                    stockDataManipulations stockDataManipulations = new stockDataManipulations();
                    Boolean billDeletion = stockDataManipulations.deleteBill(selectedBill);

                    if (billDeletion)
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
            catch(Exception err)
            {
                Console.WriteLine("\n UI Error in deleteBillBtn_Click: " + err.ToString());
                logger.Error("\n UI Error in deleteBillBtn_Click: " + err.ToString());
            }
        }
    }
}
