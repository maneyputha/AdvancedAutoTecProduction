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
    public partial class MainMenuAdmin : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(MainMenuAdmin));
        public String searchItemContext = "";
        private BindingSource gridViewData;
        private decimal completeTotal = 0.0m;
        //private List<billingItem> searchedBillItems = new List<billingItem>();
        private List<products> searchedProds = new List<products>();
        private static List<billingItem> billItemsGrid = new List<billingItem>();
        public MainMenuAdmin()
        {
            InitializeComponent();
            userRestrictions();
            this.Closing += form_Closing;
            searchBydataBindings();
            //categoryDataBindings();
            //this.WindowState = FormWindowState.Maximized;
            this.gridViewData = new BindingSource();
            //this.billingGrid.Columns["Code"].ReadOnly = true;
        }

        public void bindSearchItemContext()
        {
            searchItmValueTxt.Text = searchItemContext;
        }

        private void userRestrictions()
        {
            user loggedUser = wrapperDataBuffer.WrapperObject.User1;
            if (loggedUser.Role != "Admin")
            {
                generateSalesReportToolStripMenuItem.Enabled = false;
                userDataManagementToolStripMenuItem.Enabled = false;
                stockDataManagementToolStripMenuItem.Enabled = false;
                viewUsersToolStripMenuItem.Enabled = false;
            }
        }

        private static void form_Closing(object sender, CancelEventArgs e)
        {
            DialogResult formClose = MessageBox.Show("Are you sure you want to terminate application ?", "Warning !!",
                MessageBoxButtons.YesNo);
            if (formClose == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void generateSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewSalesRprt salesReport = new viewSalesRprt();
            salesReport.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult formClose = MessageBox.Show("Are you sure you want to terminate application ?", "Warning !!",
                MessageBoxButtons.YesNo);
            if (formClose == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddUsers addNewUser = new AddUsers();
                addNewUser.Show();
            }
            catch (Exception err) { logger.Error("UI Error in addUsersToolStripMenuItem_Click: " + err.ToString()); }

        }

        private void addCateogeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddCatagory newCategeory = new AddCatagory();
                newCategeory.Show();
            }
            catch (Exception err) { logger.Error("UI Error in addCateogeryToolStripMenuItem_Click: " + err.ToString()); }

        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AddProduct newProduct = new AddProduct();
                newProduct.Show();
            }
            catch (Exception err) { logger.Error("UI Error in addProductsToolStripMenuItem_Click: " + err.ToString()); }

        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewProducts viewProducts = new viewProducts();
                viewProducts.Show();
            }
            catch (Exception err) { logger.Error("UI Error in viewProductsToolStripMenuItem_Click: " + err.ToString()); }

        }

        private void viewUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewUsers viewUsers = new viewUsers();
                viewUsers.Show();
            }
            catch (Exception err) { logger.Error("UI Error in viewUsersToolStripMenuItem_Click: " + err.ToString()); }

        }

        private void viewCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                viewCateogery viewCateogery = new viewCateogery();
                viewCateogery.Show();
            }
            catch (Exception err) { logger.Error("UI Error in viewCategoriesToolStripMenuItem_Click: " + err.ToString()); }

        }

        //private void categoryDataBindings()
        //{

        //    Dictionary<int, string> selectCategory = new Dictionary<int, string>();
        //    selectCategory.Add(1, "Custom Bill");
        //    selectCategory.Add(2, "Product");
        //    //cmbBillCat.DataSource = new BindingSource(selectCategory, null);
        //    //cmbBillCat.DisplayMember = "Value";
        //    //cmbBillCat.ValueMember = "Key";
        //}

        private void searchBydataBindings()
        {
            Dictionary<int, string> selectCategory = new Dictionary<int, string>();
            selectCategory.Add(1, "Code");
            selectCategory.Add(2, "Name");
            selectCategory.Add(3, "Catagory Details");
            selectCategory.Add(4, "All");
            searchByCmb.DataSource = new BindingSource(selectCategory, null);
            searchByCmb.DisplayMember = "Value";
            searchByCmb.ValueMember = "Key";
            //int itmCategory = 2;

            //if (itmCategory == 2 || itmCategory == 3)
            //{
            //    Dictionary<int, string> selectCategory = new Dictionary<int, string>();
            //    selectCategory.Add(1, "Code");
            //    selectCategory.Add(2, "Name");
            //    searchByCmb.DataSource = new BindingSource(selectCategory, null);
            //    searchByCmb.DisplayMember = "Value";
            //    searchByCmb.ValueMember = "Key";
            //}
            //else if (itmCategory == 1)
            //{
            //    Dictionary<int, string> selectCategory = new Dictionary<int, string>();
            //    selectCategory.Add(1, "Name");
            //    searchByCmb.DataSource = new BindingSource(selectCategory, null);
            //    searchByCmb.DisplayMember = "Value";
            //    searchByCmb.ValueMember = "Key";
            //}
        }

        private void cmbBillCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchBydataBindings();
        }

        private void selectCode_Click(object sender, EventArgs e)
        {
            //int catType = ((KeyValuePair<int, string>)cmbBillCat.SelectedItem).Key;
            int itmType = ((KeyValuePair<int, string>)searchByCmb.SelectedItem).Key;
            seleteBillProduct selectBillProduct = new seleteBillProduct(this, 2, itmType);
            selectBillProduct.Show();
        }

        private void add2BillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(searchItmValueTxt.Text.Equals("") || searchItmValueTxt.Text.Equals(null) || (searchItmValueTxt.Text.Length > 0 && searchItmValueTxt.Text.Trim().Length == 0)))
                {
                    lstBxSearchItms.Items.Clear();
                    String itmType = this.searchByCmb.GetItemText(this.searchByCmb.SelectedItem);
                    String srchValue = searchItmValueTxt.Text;
                    int quantity = Convert.ToInt32(qtyTxt.Value.ToString());
                    stockDataManipulations sdm1 = new stockDataManipulations();
                    Console.WriteLine("Search val is: " + srchValue);
                    List<products> prds1 = sdm1.searchNAddProds(srchValue, itmType);
                    Console.WriteLine(prds1.Count);
                    if (prds1.Count > 1)
                    {
                        searchedProds = prds1;
                        lstBxSearchItms.Items.Clear();
                        foreach (products tmpSPrd in searchedProds)
                        {
                            lstBxSearchItms.Items.Add(tmpSPrd.ProductCode + ": " + tmpSPrd.ProductName + ": " + tmpSPrd.ProductPrice);
                        }

                    }
                    else if (prds1.Count.Equals(1) && (!prds1.ElementAt(0).ProductID.Equals(0)))
                    {
                        //Console.WriteLine("inside cheking availbility");
                        lstBxSearchItms.Items.Clear();
                        if (prds1[0].Quantity >= quantity && (!quantity.Equals(0)))
                        {
                            if (!isProdAvailable(prds1[0]))
                            {
                                //Console.WriteLine("inside cheking availbility");
                                decimal total = prds1[0].ProductPrice * quantity;
                                billItemsGrid.Add(new billingItem(0, null, prds1[0], quantity, total, "Product"));
                                generateGrid();
                            }
                            else
                            {
                                MessageBox.Show("Product already added to the bill.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Product quantity is lower than the added quantity. \n Please enter a less amount or add more products", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No product was found for the given search keyword", "Invalid Search Data");
                    }
                }
                else
                {
                    MessageBox.Show("You didnt enter any search data. \n Please enter a proper search value", "Empty Search Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception err)
            {
                logger.Error("UI Error in add2BillBtn_Click: " + err.ToString());
                Console.WriteLine("UI Error in add2BillBtn_Click: " + err.ToString());

            }

            //try 
            //{
            //    lstBxSearchItms.Items.Clear();
            //    String catType = this.cmbBillCat.GetItemText(this.cmbBillCat.SelectedItem);
            //    //Console.WriteLine("cat type is"+catType);
            //    String itmType = this.searchByCmb.GetItemText(this.searchByCmb.SelectedItem);
            //    String srchValue = searchItmValueTxt.Text;
            //    int quantity = Convert.ToInt32(qtyTxt.Value.ToString());
            //    stockDataManipulations stockDataManipulations = new stockDataManipulations();

            //    searchedBillItems = stockDataManipulations.fillBillObject(catType, itmType, srchValue, quantity);
            //    if (searchedBillItems.Count > 1)
            //    {

            //        lstBxSearchItms.Items.Clear();
            //        foreach (issueBill tmpBill in searchedBillItems)
            //        {
            //            lstBxSearchItms.Items.Add(tmpBill.id + ": " + tmpBill.Item_Code + ": " + tmpBill.Item_Name);
            //        }

            //    }
            //    else if (searchedBillItems.Count.Equals(1) && (!searchedBillItems.ElementAt(0).id.Equals(0)))
            //    {
            //        lstBxSearchItms.Items.Clear();
            //        issueBill tmpBill = searchedBillItems.ElementAt(0);
            //        gridViewData.Add(tmpBill);
            //        billingGrid.DataSource = gridViewData;
            //    }
            //}
            //catch (Exception err) { logger.Error("UI Error in add2BillBtn_Click: " + err.ToString()); }


        }

        private void billBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String customer_name = txtCustName.Text;
                DateTime bill_date = DateTime.Now;
                decimal bill_total = 0m;
                foreach (billingItem bIX1 in billItemsGrid)
                {
                    bill_total = bill_total + bIX1.Total;
                }
                Boolean result = new stockDataManipulations().issueBill(billItemsGrid, txtCustName.Text, txtCustTel.Text, wrapperDataBuffer.WrapperObject.User1.Username, bill_date, bill_total, txtCarNo.Text);
                if (result.Equals(true))
                {
                    //From Here Bill Printing Starts                  
                    DialogResult result1 = MessageBox.Show("Do you want to print this bill?",
        "Print Bill?",
        MessageBoxButtons.YesNo);
                    if (result1 == DialogResult.Yes)
                    {
                        List<billingItem> printBillItmLst = new List<billingItem>();

                        for (int i = 0; i < billItemsGrid.Count; i++)
                        {
                            if (billingGrid.Rows[i].Cells[0].Value.Equals("YES"))
                            {
                                printBillItmLst.Add(billItemsGrid[i]);
                            }
                        }
                        billItemsGrid = printBillItmLst;
                        PrintDialog printDialog = new PrintDialog();

                        PrintDocument printDocument = new PrintDocument();

                        printDialog.Document = printDocument; //add the document to the dialog box...        

                        printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

                        //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
                        //Console.Write(PrintSettings.InstalledPrinters);
                        DialogResult result2 = printDialog.ShowDialog();

                        if (result2 == DialogResult.OK)
                        {
                            printDocument.Print();

                        }
                        billItemsGrid.Clear();
                        searchedProds.Clear();
                        billingGrid.Rows.Clear();
                    }
                }
                else if (result.Equals(false))
                {
                    MessageBox.Show("Bill Generation failed.\n Data werent added properly", "Bill Generation failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception err)
            {
                Console.WriteLine("UIL Error in MainMenuAdmin.billBtn_Click: " + err.ToString());
                logger.Error("UI Error in MainMenuAdmin.billBtn_Click: " + err.ToString());
            }
            //try 
            //{
            //    stockDataManipulations stockDataManipulations = new stockDataManipulations();
            //    List<issueBill> userBill = new List<issueBill>();
            //    String customer_name = txtCustName.Text;
            //    String customer_tel = txtCustTel.Text;
            //    decimal bill_total = 0m;
            //    DateTime bill_date = DateTime.Now;
            //    String username = wrapperDataBuffer.WrapperObject.User1.Username;
            //    foreach (DataGridViewRow row in billingGrid.Rows)
            //    {

            //        int id = Convert.ToInt32(row.Cells[0].Value.ToString());
            //        string category = row.Cells[1].Value.ToString();
            //        string itemCode = row.Cells[2].Value.ToString();
            //        string itemName = row.Cells[3].Value.ToString();
            //        int quantity = Convert.ToInt32(row.Cells[4].Value.ToString());
            //        decimal price = Convert.ToDecimal(row.Cells[5].Value.ToString());
            //        decimal total = Convert.ToDecimal(row.Cells[6].Value.ToString());
            //        bill_total = bill_total + total;



            //        issueBill billItem = new issueBill(id, category, itemCode, itemName,
            //            quantity, price, total);
            //        userBill.Add(billItem);
            //    }
            //    stockDataManipulations sm1 = new stockDataManipulations();
            //    sm1.billItem(customer_name, customer_tel, username, bill_date, bill_total, userBill);
            //}
            //catch (Exception err) { logger.Error("UI Error in billBtn_Click: " + err.ToString()); }


        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            searchItmValueTxt.Text = "";
            txtCustName.Text = "";
            txtCustTel.Text = "";
            txtCarNo.Text = "";
            billingGrid.DataSource = null;
        }

        private void removeGridItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (billingGrid.RowCount != 0)
                {
                    int selectedIndex = billingGrid.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        completeTotal = completeTotal-billItemsGrid[selectedIndex].Total;
                        billItemsGrid.RemoveAt(selectedIndex);
                        billingGrid.Rows.RemoveAt(selectedIndex);
                        billingGrid.Refresh();
                        lblBillTotal.Text = "" + completeTotal;

                    }
                }
            }
            catch (Exception err) { logger.Error("UI Error in removeGridItem_Click: " + err.ToString()); }

        }

        private void currentStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentStocks viewStock = new currentStocks();
                viewStock.Show();
            }
            catch (Exception err) { logger.Error("UI Error in currentStockToolStripMenuItem_Click: " + err.ToString()); }
            //Console.WriteLine("CurrentStock");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!searchedProds.Count.Equals(0))
                {
                    int quantity = Convert.ToInt32(qtyTxt.Value.ToString());
                    //searchedBillItems.ElementAt(lstBxSearchItms.SelectedIndex).Total = searchedProds.ElementAt(lstBxSearchItms.SelectedIndex).ProductPrice * quantity;
                    //gridViewData.Add(searchedBillItems.ElementAt(lstBxSearchItms.SelectedIndex));
                    //billingGrid.DataSource = gridViewData;
                    if (searchedProds.ElementAt(lstBxSearchItms.SelectedIndex).Quantity > quantity)
                    {
                        if (!isProdAvailable(searchedProds[0]))
                        {
                            decimal total = searchedProds[0].ProductPrice * quantity;
                            billItemsGrid.Add(new billingItem(0, null, searchedProds[0], quantity, total, "Product"));
                            generateGrid();
                        }
                        else
                        {
                            MessageBox.Show("Product already added to the bill.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product quantity is lower than the added quantity.");
                    }
                    lstBxSearchItms.Items.Clear();
                }
                else
                {
                    MessageBox.Show("No data found in the search list");
                }
            }
            catch (Exception err)
            {
                //Console.WriteLine("Error in btnAdd_Click: " + err.ToString());
                logger.Error("UI Error in btnAdd_Click: " + err.ToString());
            }
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStock addNewStock = new AddStock();
            addNewStock.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNewItem ani1 = new AddNewItem();
            ani1.ShowDialog();
            generateGrid();

        }

        public void generateGrid()
        {
            //int rowNo = billingGrid.RowCount;
            //int count = 0;
            billingGrid.Rows.Clear();
            completeTotal = 0.0m;
            
            for (int i = 0; i < billItemsGrid.Count; i++)
            {
                billingGrid.Rows.Add();
                
                billingGrid.Rows[i].Cells[0].Value = "YES";
                if (billItemsGrid[i]._type.Equals("Service"))
                {
                    billingGrid.Rows[i].Cells[2].Value = billItemsGrid[i].Service.Service_Name;
                    billingGrid.Rows[i].Cells[3].Value = billItemsGrid[i].Service.Service_Price;
                    billingGrid.Rows[i].Cells[4].Value = billItemsGrid[i].Quantiy;
                    billingGrid.Rows[i].Cells[5].Value = billItemsGrid[i].Total;
                    completeTotal = completeTotal + billItemsGrid[i].Total;
                }
                if (billItemsGrid[i]._type.Equals("Product"))
                {
                    billingGrid.Rows[i].Cells[1].Value = billItemsGrid[i].Product.ProductCode;
                    billingGrid.Rows[i].Cells[2].Value = billItemsGrid[i].Product.ProductName;
                    billingGrid.Rows[i].Cells[3].Value = billItemsGrid[i].Product.ProductPrice;
                    billingGrid.Rows[i].Cells[4].Value = billItemsGrid[i].Quantiy;
                    billingGrid.Rows[i].Cells[5].Value = billItemsGrid[i].Total;
                    completeTotal = completeTotal + billItemsGrid[i].Total;
                }
            }
            lblBillTotal.Text = "" + completeTotal;
        }

        public Boolean isProdAvailable(products prd1)
        {
            Boolean result = false;
            foreach (billingItem tmpBItm in billItemsGrid)
            {
                if (tmpBItm._type.Equals("Product"))
                {
                    if (tmpBItm.Product.ProductID.Equals(prd1.ProductID))
                    {
                        result = true;
                    }

                }
            }
            return result;
        }

        public static void addnewItemtoList(String name, decimal price, int qty)
        {
            serviceProducts sp1 = new serviceProducts(0, name, qty, price);
            decimal total = price * qty;
            billItemsGrid.Add(new billingItem(0, sp1, null, qty, total, "Service"));
        }

        public DataGrid generatePrintTable()
        {
            //DataTable table1 = new DataTable();
            //DataColumn column1;
            DataGridTextBoxColumn txtColumn;

            DataGrid dg1 = new DataGrid();

            DataGridTableStyle tableStyle = new DataGridTableStyle();
            txtColumn = new DataGridTextBoxColumn();
            txtColumn.MappingName = "id";
            txtColumn.HeaderText = "ID/Code";
            txtColumn.Width = 10;
            tableStyle.GridColumnStyles.Add(txtColumn);

            txtColumn = new DataGridTextBoxColumn();
            txtColumn.MappingName = "itemName";
            txtColumn.HeaderText = "Item Name";
            txtColumn.Width = 150;
            tableStyle.GridColumnStyles.Add(txtColumn);

            txtColumn = new DataGridTextBoxColumn();
            txtColumn.MappingName = "qty";
            txtColumn.HeaderText = "Quantity";
            txtColumn.Width = 10;
            tableStyle.GridColumnStyles.Add(txtColumn);

            txtColumn = new DataGridTextBoxColumn();
            txtColumn.MappingName = "price";
            txtColumn.HeaderText = "Unit Price";
            txtColumn.Width = 12;
            tableStyle.GridColumnStyles.Add(txtColumn);

            txtColumn = new DataGridTextBoxColumn();
            txtColumn.MappingName = "total";
            txtColumn.HeaderText = "Total";
            txtColumn.Width = 12;
            tableStyle.GridColumnStyles.Add(txtColumn);

            dg1.TableStyles.Add(tableStyle);
            return dg1;
        }

        public void CreateReceipt(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            //int total = 0;
            //float change = 0.00f;

            //this prints the reciept

            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;

            graphic.DrawString(" Advanced Auto Tec - Motorwork", new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY);
            string top = "Item Name".PadRight(30) + "Price";
            graphic.DrawString(top, font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------------", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + (int)fontHeight + 5; //make the spacing consistent

            decimal totalprice = 0.00m;

            DataGrid dg1 = generatePrintTable();
            for (int ix = 0; ix < billItemsGrid.Count; ix++)
            {
                if (billingGrid.Rows[ix].Cells[0].Value.Equals("YES"))
                {
                    String producPrintString = "";
                    if (billItemsGrid[ix]._type.Equals("Product"))
                    {

                        String prodCode = billItemsGrid[ix].Product.ProductCode;
                        if (prodCode.Length < 30)
                        {
                            int paddedLngth = 30 - prodCode.Length;
                            producPrintString = producPrintString + prodCode.PadRight(paddedLngth);
                        }
                        String prodName = billItemsGrid[ix].Product.ProductName;
                        if (prodName.Length < 250)
                        {
                            int paddedLngth = 250 - prodName.Length;
                            producPrintString = producPrintString + prodName.PadRight(paddedLngth);
                        }

                        String prodQty = "" + billItemsGrid[ix].Quantiy;
                        if (prodQty.Length < 30)
                        {
                            int paddedLngth = 50 - prodQty.Length;
                            producPrintString = producPrintString + prodQty.PadRight(paddedLngth);
                        }

                        String unitPrice = "" + billItemsGrid[ix].Product.ProductPrice;
                        if (unitPrice.Length < 30)
                        {
                            int paddedLngth = 50 - unitPrice.Length;
                            producPrintString = producPrintString + unitPrice.PadRight(paddedLngth);
                        }

                        String ProdTotal = "" + billItemsGrid[ix].Total;
                        totalprice = totalprice + billItemsGrid[ix].Total;
                        if (ProdTotal.Length < 50)
                        {
                            int paddedLngth = 50 - ProdTotal.Length;
                            producPrintString = producPrintString + ProdTotal.PadRight(paddedLngth);
                        }
                    }
                    else if (billItemsGrid[ix]._type.Equals("Service"))
                    {

                        String prodCode = "" + billItemsGrid[ix].Service.Service_ID;
                        if (prodCode.Length < 30)
                        {
                            int paddedLngth = 30 - prodCode.Length;
                            producPrintString = producPrintString + prodCode.PadRight(paddedLngth);
                        }
                        String prodName = billItemsGrid[ix].Service.Service_Name;
                        if (prodName.Length < 250)
                        {
                            int paddedLngth = 250 - prodName.Length;
                            producPrintString = producPrintString + prodName.PadRight(paddedLngth);
                        }
                        String prodQty = "" + billItemsGrid[ix].Quantiy;
                        if (prodQty.Length < 30)
                        {
                            int paddedLngth = 50 - prodQty.Length;
                            producPrintString = producPrintString + prodQty.PadRight(paddedLngth);
                        }

                        String unitPrice = "" + billItemsGrid[ix].Service.Service_Price;
                        if (unitPrice.Length < 30)
                        {
                            int paddedLngth = 50 - unitPrice.Length;
                            producPrintString = producPrintString + unitPrice.PadRight(paddedLngth);
                        }

                        String ProdTotal = "" + billItemsGrid[ix].Total;
                        totalprice = totalprice + billItemsGrid[ix].Total;
                        if (ProdTotal.Length < 50)
                        {
                            int paddedLngth = 50 - ProdTotal.Length;
                            producPrintString = producPrintString + ProdTotal.PadRight(paddedLngth);
                        }
                    }

                    graphic.DrawString(producPrintString, font, new SolidBrush(Color.Black), startX, startY + offset);
                    offset = offset + (int)fontHeight + 5;
                }

            }

            offset = offset + 20;
            graphic.DrawString("Total to pay (R.S.) ".PadRight(30) + String.Format("{0:c}", totalprice), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 30; //make some room so that the total stands out.
            graphic.DrawString("     Thank-you for your custom,", font, new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 15;
            graphic.DrawString("       please come back soon!", font, new SolidBrush(Color.Black), startX, startY + offset);
            Font font2 = new Font("Courier New", 8);
            offset = offset + 15;
            graphic.DrawString("CDENSOFT", font, new SolidBrush(Color.Black), startX, startY + offset);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    PrintDialog printDialog = new PrintDialog();

            //    PrintDocument printDocument = new PrintDocument();

            //    printDialog.Document = printDocument; //add the document to the dialog box...        

            //    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //    //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            //    DialogResult result = printDialog.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        printDocument.Print();

            //    }
            //}
            //catch (Exception err)
            //{
            //    //Console.WriteLine("UIL Error in button2_Click: " + err.ToString());
            //    logger.Error("UIL Error in button2_Click: " + err.ToString());
            //}
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //try
            //{
            //    PrintDialog printDialog = new PrintDialog();

            //    PrintDocument printDocument = new PrintDocument();

            //    printDialog.Document = printDocument; //add the document to the dialog box...        

            //    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateReceipt); //add an event handler that will do the printing

            //    //on a till you will not want to ask the user where to print but this is fine for the test envoironment.
            //    //Console.Write(PrintSettings.InstalledPrinters);
            //    DialogResult result = printDialog.ShowDialog();

            //    if (result == DialogResult.OK)
            //    {
            //        printDocument.Print();

            //    }
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine("UIL Error in button2_Click: " + err.ToString());
            //    logger.Error("UI Error in button2_Click: " + err.ToString());
            //}
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            
            DialogResult result1 = MessageBox.Show("Are you sure you want to logout?",
        "Logout?",
        MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes) 
            {
                billItemsGrid.Clear();
                wrapperDataBuffer.WrapperObject = null;
                new Form1().Show();
                this.Dispose();
            }
        }



    }
}
