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
    public partial class viewProducts : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(viewProducts));
        BindingSource gridViewData;
        public viewProducts()
        {
            InitializeComponent();
            this.gridViewData = new BindingSource();
            bindDataTableData();
        }

        private void bindDataTableData()
        {
            stockDataManipulations stockDataManipulations = new stockDataManipulations();
            List<products> productList = stockDataManipulations.getAllProducts();

            for (int i = 0; i < productList.Count; i++)
            {
                productsDataGrid.Rows.Add();
                productsDataGrid.Rows[i].Cells[0].Value = productList[i].ProductID;
                productsDataGrid.Rows[i].Cells[1].Value = productList[i].ProductCode;
                productsDataGrid.Rows[i].Cells[2].Value = productList[i].ProductName;
                productsDataGrid.Rows[i].Cells[3].Value = productList[i].ProductMake;
                productsDataGrid.Rows[i].Cells[4].Value = productList[i].ProductModel;
                productsDataGrid.Rows[i].Cells[5].Value = productList[i].ProductDescription;
                productsDataGrid.Rows[i].Cells[6].Value = productList[i].ProductCateogery.Item_Category_Name;
                productsDataGrid.Rows[i].Cells[7].Value = productList[i].ProductPrice;
                productsDataGrid.Rows[i].Cells[8].Value = productList[i].Quantity;
                productsDataGrid.Rows[i].Cells[9].Value = "Delete";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedIndex = productsDataGrid.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                string productId = productsDataGrid.Rows[selectedIndex].Cells[0].Value.ToString();
                string productCode = productsDataGrid.Rows[selectedIndex].Cells[1].Value.ToString();
                string productName = productsDataGrid.Rows[selectedIndex].Cells[2].Value.ToString();
                string productMake = productsDataGrid.Rows[selectedIndex].Cells[3].Value.ToString();
                string productModel = productsDataGrid.Rows[selectedIndex].Cells[4].Value.ToString();
                string productDescription = productsDataGrid.Rows[selectedIndex].Cells[5].Value.ToString();
                string productPrice = productsDataGrid.Rows[selectedIndex].Cells[6].Value.ToString();
                itemCategory itemCategory = (itemCategory)productsDataGrid.Rows[selectedIndex].Cells[7].Value;
                string quantity = productsDataGrid.Rows[selectedIndex].Cells[8].Value.ToString();

                products selectedProduct = new products(int.Parse(productId), productCode, productName, productMake, productModel,
                    productDescription, decimal.Parse(productPrice), itemCategory, int.Parse(quantity));

                stockDataManipulations stockDataManipulations = new stockDataManipulations();
                Boolean stockDeletion = stockDataManipulations.deleteProduct(selectedProduct);
               
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
