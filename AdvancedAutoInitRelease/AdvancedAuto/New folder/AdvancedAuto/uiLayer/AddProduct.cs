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
    public partial class AddProduct : Form
    {

        Timer labelTimer;

        public AddProduct()
        {
            InitializeComponent();
            pcodeVerify.Font = new Font("Calibri", 10);
            pnameVerify.Font = new Font("Calibri", 10);
            ppriceVerify.Font = new Font("Calibri", 10);
            cmbCatVerify.Font = new Font("Calibri", 10);
            labelTimer = new Timer();
            this.txtProductPrc.KeyPress += new KeyPressEventHandler(txtProductPrc_KeyPress);
            categoryDataBindings();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
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
                String proCode = (txtProductCode.Text).Clone().ToString();
                String proName = (txtProductName.Text).Clone().ToString();
                String proMake = (txtProductMake.Text).Clone().ToString();
                String proModel = (txtProductModel.Text).Clone().ToString();
                String proDescription = (txtProductDesc.Text).Clone().ToString();
                String proPrice = (txtProductPrc.Text).Clone().ToString();
                String proQuantity = (txtPrdQty.Text).Clone().ToString();
                decimal convProdPrice = decimal.Parse(proPrice);
                int convProdQuantity = int.Parse(proQuantity);
                itemCategory psCategory = ((KeyValuePair<itemCategory, string>)combProCat.SelectedItem).Key;
                Console.WriteLine("pcat ID: "+psCategory.Item_Category_ID);
                products newProduct = new products(-1, proCode, proName, proMake, proModel, proDescription,
                    convProdPrice, psCategory, convProdQuantity);

                stockDataManipulations stockDataManipulations = new stockDataManipulations();
                Boolean productInsertionFlag = stockDataManipulations.addNewProduct(newProduct);
                if (productInsertionFlag)
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
            pcodeVerify.Hide();
            pnameVerify.Hide();
            ppriceVerify.Hide();
            cmbCatVerify.Hide();
        }

        private void categoryDataBindings()
        {
            stockDataManipulations stockDataManipulation = new stockDataManipulations();
            List<itemCategory> categories = stockDataManipulation.getAllCategories();
            Dictionary<itemCategory, string> productCategory = new Dictionary<itemCategory, string>();
            itemCategory defCategory = new itemCategory(-1, "Default", null);
            productCategory.Add(defCategory, defCategory.Item_Category_Name);
            foreach (itemCategory category in categories)
            {
                productCategory.Add(category, category.Item_Category_Name);
            }
            combProCat.DataSource = new BindingSource(productCategory, null);
            combProCat.DisplayMember = "Value";
            combProCat.ValueMember = "Key";
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
    }
}
