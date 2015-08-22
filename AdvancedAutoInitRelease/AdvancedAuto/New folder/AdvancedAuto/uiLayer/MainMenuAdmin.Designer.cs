namespace uiLayer
{
    partial class MainMenuAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDataManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCateogeryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userDataManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSalesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblBillTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCarNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCustTel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstBxSearchItms = new System.Windows.Forms.ListBox();
            this.removeGridItem = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.billBtn = new System.Windows.Forms.Button();
            this.qtyTxt = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.billingGrid = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchByCmb = new System.Windows.Forms.ComboBox();
            this.selectCode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchItmValueTxt = new System.Windows.Forms.TextBox();
            this.add2BillBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.stockDataManagementToolStripMenuItem,
            this.userDataManagementToolStripMenuItem,
            this.dataViewsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1055, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stockDataManagementToolStripMenuItem
            // 
            this.stockDataManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.addCateogeryToolStripMenuItem,
            this.addStockToolStripMenuItem});
            this.stockDataManagementToolStripMenuItem.Name = "stockDataManagementToolStripMenuItem";
            this.stockDataManagementToolStripMenuItem.Size = new System.Drawing.Size(149, 20);
            this.stockDataManagementToolStripMenuItem.Text = "Stock Data Management";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addProductsToolStripMenuItem.Text = "Add Products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // addCateogeryToolStripMenuItem
            // 
            this.addCateogeryToolStripMenuItem.Name = "addCateogeryToolStripMenuItem";
            this.addCateogeryToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addCateogeryToolStripMenuItem.Text = "Add Cateogery";
            this.addCateogeryToolStripMenuItem.Click += new System.EventHandler(this.addCateogeryToolStripMenuItem_Click);
            // 
            // addStockToolStripMenuItem
            // 
            this.addStockToolStripMenuItem.Name = "addStockToolStripMenuItem";
            this.addStockToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addStockToolStripMenuItem.Text = "Add Stock";
            this.addStockToolStripMenuItem.Click += new System.EventHandler(this.addStockToolStripMenuItem_Click);
            // 
            // userDataManagementToolStripMenuItem
            // 
            this.userDataManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUsersToolStripMenuItem});
            this.userDataManagementToolStripMenuItem.Name = "userDataManagementToolStripMenuItem";
            this.userDataManagementToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.userDataManagementToolStripMenuItem.Text = "User Data Management";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.addUsersToolStripMenuItem.Text = "Add Users";
            this.addUsersToolStripMenuItem.Click += new System.EventHandler(this.addUsersToolStripMenuItem_Click);
            // 
            // dataViewsToolStripMenuItem
            // 
            this.dataViewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewProductsToolStripMenuItem,
            this.currentStockToolStripMenuItem,
            this.viewCategoriesToolStripMenuItem,
            this.viewUsersToolStripMenuItem,
            this.generateSalesReportToolStripMenuItem});
            this.dataViewsToolStripMenuItem.Name = "dataViewsToolStripMenuItem";
            this.dataViewsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dataViewsToolStripMenuItem.Text = "Data Views";
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewProductsToolStripMenuItem.Text = "View Products";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // currentStockToolStripMenuItem
            // 
            this.currentStockToolStripMenuItem.Name = "currentStockToolStripMenuItem";
            this.currentStockToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.currentStockToolStripMenuItem.Text = "Current Stock";
            this.currentStockToolStripMenuItem.Click += new System.EventHandler(this.currentStockToolStripMenuItem_Click);
            // 
            // viewCategoriesToolStripMenuItem
            // 
            this.viewCategoriesToolStripMenuItem.Name = "viewCategoriesToolStripMenuItem";
            this.viewCategoriesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewCategoriesToolStripMenuItem.Text = "View Categories";
            this.viewCategoriesToolStripMenuItem.Click += new System.EventHandler(this.viewCategoriesToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            this.viewUsersToolStripMenuItem.Click += new System.EventHandler(this.viewUsersToolStripMenuItem_Click);
            // 
            // generateSalesReportToolStripMenuItem
            // 
            this.generateSalesReportToolStripMenuItem.Name = "generateSalesReportToolStripMenuItem";
            this.generateSalesReportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.generateSalesReportToolStripMenuItem.Text = "Generate Sales Report";
            this.generateSalesReportToolStripMenuItem.Click += new System.EventHandler(this.generateSalesReportToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.lblBillTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtCarNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtCustTel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCustName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lstBxSearchItms);
            this.panel1.Controls.Add(this.removeGridItem);
            this.panel1.Controls.Add(this.clrBtn);
            this.panel1.Controls.Add(this.billBtn);
            this.panel1.Controls.Add(this.qtyTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.billingGrid);
            this.panel1.Controls.Add(this.searchByCmb);
            this.panel1.Controls.Add(this.selectCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.searchItmValueTxt);
            this.panel1.Controls.Add(this.add2BillBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1055, 552);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(15, 13);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 36;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblBillTotal
            // 
            this.lblBillTotal.AutoSize = true;
            this.lblBillTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillTotal.Location = new System.Drawing.Point(960, 468);
            this.lblBillTotal.Name = "lblBillTotal";
            this.lblBillTotal.Size = new System.Drawing.Size(36, 18);
            this.lblBillTotal.TabIndex = 35;
            this.lblBillTotal.Text = "0.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total (R.S.): ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(871, 517);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txtCarNo
            // 
            this.txtCarNo.Location = new System.Drawing.Point(914, 23);
            this.txtCarNo.Name = "txtCarNo";
            this.txtCarNo.Size = new System.Drawing.Size(129, 20);
            this.txtCarNo.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(802, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Vehicle No.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add New Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustTel
            // 
            this.txtCustTel.Location = new System.Drawing.Point(667, 23);
            this.txtCustTel.Name = "txtCustTel";
            this.txtCustTel.Size = new System.Drawing.Size(129, 20);
            this.txtCustTel.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Customer Tel.";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(401, 23);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(142, 20);
            this.txtCustName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Customer Name:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 463);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add From Search Results";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstBxSearchItms
            // 
            this.lstBxSearchItms.FormattingEnabled = true;
            this.lstBxSearchItms.Location = new System.Drawing.Point(15, 207);
            this.lstBxSearchItms.Name = "lstBxSearchItms";
            this.lstBxSearchItms.Size = new System.Drawing.Size(267, 251);
            this.lstBxSearchItms.TabIndex = 24;
            // 
            // removeGridItem
            // 
            this.removeGridItem.Location = new System.Drawing.Point(455, 509);
            this.removeGridItem.Name = "removeGridItem";
            this.removeGridItem.Size = new System.Drawing.Size(101, 31);
            this.removeGridItem.TabIndex = 23;
            this.removeGridItem.Text = "Remove Item";
            this.removeGridItem.UseVisualStyleBackColor = true;
            this.removeGridItem.Click += new System.EventHandler(this.removeGridItem_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(562, 509);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(132, 31);
            this.clrBtn.TabIndex = 22;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // billBtn
            // 
            this.billBtn.Location = new System.Drawing.Point(700, 509);
            this.billBtn.Name = "billBtn";
            this.billBtn.Size = new System.Drawing.Size(132, 31);
            this.billBtn.TabIndex = 21;
            this.billBtn.Text = "Bill";
            this.billBtn.UseVisualStyleBackColor = true;
            this.billBtn.Click += new System.EventHandler(this.billBtn_Click);
            // 
            // qtyTxt
            // 
            this.qtyTxt.Location = new System.Drawing.Point(142, 90);
            this.qtyTxt.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.qtyTxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qtyTxt.Name = "qtyTxt";
            this.qtyTxt.Size = new System.Drawing.Size(140, 20);
            this.qtyTxt.TabIndex = 20;
            this.qtyTxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quantity";
            // 
            // billingGrid
            // 
            this.billingGrid.AllowUserToAddRows = false;
            this.billingGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.productCode,
            this.productName,
            this.productPrice,
            this.productQuantity,
            this.total});
            this.billingGrid.Location = new System.Drawing.Point(297, 75);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.Size = new System.Drawing.Size(755, 383);
            this.billingGrid.TabIndex = 18;
            // 
            // Category
            // 
            this.Category.HeaderText = "Print";
            this.Category.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.Category.Name = "Category";
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productQuantity
            // 
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // searchByCmb
            // 
            this.searchByCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchByCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchByCmb.FormattingEnabled = true;
            this.searchByCmb.Location = new System.Drawing.Point(142, 50);
            this.searchByCmb.Name = "searchByCmb";
            this.searchByCmb.Size = new System.Drawing.Size(140, 21);
            this.searchByCmb.TabIndex = 17;
            // 
            // selectCode
            // 
            this.selectCode.Location = new System.Drawing.Point(258, 500);
            this.selectCode.Name = "selectCode";
            this.selectCode.Size = new System.Drawing.Size(34, 23);
            this.selectCode.TabIndex = 15;
            this.selectCode.Text = "...";
            this.selectCode.UseVisualStyleBackColor = true;
            this.selectCode.Visible = false;
            this.selectCode.Click += new System.EventHandler(this.selectCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search By:";
            // 
            // searchItmValueTxt
            // 
            this.searchItmValueTxt.Location = new System.Drawing.Point(15, 125);
            this.searchItmValueTxt.Name = "searchItmValueTxt";
            this.searchItmValueTxt.Size = new System.Drawing.Size(267, 20);
            this.searchItmValueTxt.TabIndex = 13;
            // 
            // add2BillBtn
            // 
            this.add2BillBtn.Location = new System.Drawing.Point(15, 151);
            this.add2BillBtn.Name = "add2BillBtn";
            this.add2BillBtn.Size = new System.Drawing.Size(267, 23);
            this.add2BillBtn.TabIndex = 12;
            this.add2BillBtn.Text = "Search and Add";
            this.add2BillBtn.UseVisualStyleBackColor = true;
            this.add2BillBtn.Click += new System.EventHandler(this.add2BillBtn_Click);
            // 
            // MainMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1055, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenuAdmin";
            this.Text = "Main Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyTxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDataManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userDataManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataViewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateSalesReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add2BillBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchItmValueTxt;
        private System.Windows.Forms.Button selectCode;
        private System.Windows.Forms.ComboBox searchByCmb;
        private System.Windows.Forms.DataGridView billingGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown qtyTxt;
        private System.Windows.Forms.Button billBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button removeGridItem;
        private System.Windows.Forms.ToolStripMenuItem currentStockToolStripMenuItem;
        private System.Windows.Forms.ListBox lstBxSearchItms;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtCustTel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem addStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCateogeryToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.TextBox txtCarNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBillTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
    }
}