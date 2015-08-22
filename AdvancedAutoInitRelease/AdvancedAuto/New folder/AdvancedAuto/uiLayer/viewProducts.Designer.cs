namespace uiLayer
{
    partial class viewProducts
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productsDataGrid = new System.Windows.Forms.DataGridView();
            this.updateBtn = new System.Windows.Forms.Button();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuatity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryObj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(874, 388);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 42);
            this.deleteBtn.TabIndex = 48;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productsDataGrid
            // 
            this.productsDataGrid.AllowUserToAddRows = false;
            this.productsDataGrid.AllowUserToDeleteRows = false;
            this.productsDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.productsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productCode,
            this.productName,
            this.productMake,
            this.productModel,
            this.productDescription,
            this.productCategory,
            this.productPrice,
            this.productQuatity,
            this.categoryObj});
            this.productsDataGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.productsDataGrid.Location = new System.Drawing.Point(0, 0);
            this.productsDataGrid.Name = "productsDataGrid";
            this.productsDataGrid.Size = new System.Drawing.Size(999, 370);
            this.productsDataGrid.TabIndex = 51;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(755, 388);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(113, 42);
            this.updateBtn.TabIndex = 52;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Visible = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.Name = "productID";
            this.productID.ReadOnly = true;
            this.productID.Visible = false;
            this.productID.Width = 80;
            // 
            // productCode
            // 
            this.productCode.HeaderText = "Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Width = 50;
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 200;
            // 
            // productMake
            // 
            this.productMake.HeaderText = "Make";
            this.productMake.Name = "productMake";
            this.productMake.ReadOnly = true;
            // 
            // productModel
            // 
            this.productModel.HeaderText = "Model";
            this.productModel.Name = "productModel";
            this.productModel.ReadOnly = true;
            // 
            // productDescription
            // 
            this.productDescription.HeaderText = "Description";
            this.productDescription.Name = "productDescription";
            this.productDescription.ReadOnly = true;
            this.productDescription.Width = 240;
            // 
            // productCategory
            // 
            this.productCategory.HeaderText = "Category";
            this.productCategory.Name = "productCategory";
            this.productCategory.ReadOnly = true;
            this.productCategory.Width = 80;
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            // 
            // productQuatity
            // 
            this.productQuatity.HeaderText = "Quantity";
            this.productQuatity.Name = "productQuatity";
            this.productQuatity.ReadOnly = true;
            this.productQuatity.Width = 80;
            // 
            // categoryObj
            // 
            this.categoryObj.HeaderText = "Category Object";
            this.categoryObj.Name = "categoryObj";
            this.categoryObj.Visible = false;
            this.categoryObj.Width = 80;
            // 
            // viewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 442);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.productsDataGrid);
            this.Controls.Add(this.deleteBtn);
            this.Name = "viewProducts";
            this.Text = "Product List";
            ((System.ComponentModel.ISupportInitialize)(this.productsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridView productsDataGrid;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMake;
        private System.Windows.Forms.DataGridViewTextBoxColumn productModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuatity;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryObj;
    }
}