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
    public partial class editProducts : Form
    {
        products product;
        viewProducts currentView;
        Timer labelTimer;

        public editProducts(products product, viewProducts currentView)
        {
            InitializeComponent();
            this.product = product;
            this.currentView = currentView;
            pcodeVerify.Font = new Font("Calibri", 10);
            pnameVerify.Font = new Font("Calibri", 10);
            ppriceVerify.Font = new Font("Calibri", 10);
            cmbCatVerify.Font = new Font("Calibri", 10);
            labelTimer = new Timer();
            this.txtProductPrc.KeyPress += new KeyPressEventHandler(txtProductPrc_KeyPress);
            setData();
        }

        private void setData()
        {
            txtProductCode.Text = product.ProductCode;
            txtProductName.Text = product.ProductName;
            txtProductMake.Text = product.ProductMake;
            txtProductModel.Text = product.ProductModel;
            txtProductDesc.Text = product.ProductDescription;
            txtProductPrc.Text = product.ProductPrice.ToString();
            txtPrdQty.Text = product.Quantity.ToString();
            categoryDataBindings();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            String pCode = ((txtProductCode.Text).Replace(" ", string.Empty)).Clone().ToString();
            String pName = ((txtProductName.Text).Replace(" ", string.Empty)).Clone().ToString();
            String pPrice = ((txtProductPrc.Text).Replace(" ", string.Empty)).Clone().ToString();
            String quantity = ((txtPrdQty.Text).Replace(" ", string.Empty)).Clone().ToString();
            itemCategory pCategory = ((KeyValuePair<itemCategory, string>)combProCat.SelectedItem).Key;

            if (pCode == "")
            {
                pcodeVerify.Show();
                hideLabelsTimer();
            }
            else if (pName == "")
            {
                pnameVerify.Show();
                hideLabelsTimer();
            }
            else if (pPrice == "")
            {
                ppriceVerify.Show();
                hideLabelsTimer();
            }
            else if (quantity == "")
            {
                ppriceVerify.Show();
                hideLabelsTimer();
            }
            else if (pCategory.Item_Category_Name == "Default")
            {
                cmbCatVerify.Show();
                hideLabelsTimer();
            }
            else
            {
                string productCode = txtProductCode.Text;
                string productName = txtProductName.Text;
                string productMake = txtProductMake.Text;
                string productModel = txtProductModel.Text;
                string productDescription = txtProductDesc.Text;
                string productPrice = txtProductPrc.Text;
                int qty = (int)txtPrdQty.Value;
                itemCategory itemCat = ((KeyValuePair<itemCategory, string>)combProCat.SelectedItem).Key;


                products product1 = new products(product.ProductID, productCode, productName, productMake, productModel,
                    productDescription, decimal.Parse(productPrice), itemCat, qty);

                stockDataManipulations stockDataManipulations = new stockDataManipulations();
                Boolean stockDeletion = stockDataManipulations.updateProduct(product1);

                if (stockDeletion)
                {
                    MessageBox.Show("Update Successfull. Data updated successfully", "Important Note",
                    MessageBoxButtons.OK);
                    currentView.updateDataTableData();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Update Failed. Error occured while Updating data", "Important Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void txtProductPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void clearForm()
        {
            txtProductCode.Text = "";
            txtProductName.Text = "";
            txtProductMake.Text = "";
            txtProductModel.Text = "";
            txtProductDesc.Text = "";
            txtProductPrc.Text = "";
            txtPrdQty.Text = "";
            labelRemover();
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
            pnameVerify.Hide();
            ppriceVerify.Hide();
            cmbCatVerify.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void categoryDataBindings()
        {
            stockDataManipulations stockDataManipulation = new stockDataManipulations();
            List<itemCategory> categories = stockDataManipulation.getAllCategories();
            Dictionary<itemCategory, string> productCategory = new Dictionary<itemCategory, string>();
            productCategory.Add(product.ProductCateogery, product.ProductCateogery.Item_Category_Name);
            foreach (itemCategory category in categories)
            {
                productCategory.Add(category, category.Item_Category_Name);
            }
            combProCat.DataSource = new BindingSource(productCategory, null);
            combProCat.DisplayMember = "Value";
            combProCat.ValueMember = "Key";
        }
    }
}
