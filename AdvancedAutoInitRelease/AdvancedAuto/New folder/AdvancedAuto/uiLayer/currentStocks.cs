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
    public partial class currentStocks : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(currentStocks));
        private BindingSource gridViewData;
        public currentStocks()
        {
            InitializeComponent();
            this.gridViewData = new BindingSource();
            bindDataGridData();
        }

        private void bindDataGridData()
        {
            stockDataManipulations stockDataManipulations = new stockDataManipulations();
            List<stock> currentStock = stockDataManipulations.getCurrentStockData();
            stocksDataGrid.DataSource = currentStock;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (stocksDataGrid.RowCount != 0)
            {
                int selectedIndex = stocksDataGrid.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    string stockId = stocksDataGrid.Rows[selectedIndex].Cells[0].Value.ToString();
                    string productId = stocksDataGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                    string productName = stocksDataGrid.Rows[selectedIndex].Cells[2].Value.ToString();
                    string details = stocksDataGrid.Rows[selectedIndex].Cells[3].Value.ToString();
                    string stockDate = stocksDataGrid.Rows[selectedIndex].Cells[4].Value.ToString();
                    string quantity = stocksDataGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                    string cost = stocksDataGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                    stock selectedStock = new stock(int.Parse(stockId), int.Parse(productId),
                        productName, details, Convert.ToDateTime(stockDate), int.Parse(quantity),decimal.Parse(cost));

                    stockDataManipulations stockDataManipulations = new stockDataManipulations();
                    Boolean stockDeletion = stockDataManipulations.deleteStock(selectedStock);

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
}
