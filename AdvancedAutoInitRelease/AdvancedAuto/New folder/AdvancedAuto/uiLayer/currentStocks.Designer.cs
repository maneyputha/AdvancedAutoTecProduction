namespace uiLayer
{
    partial class currentStocks
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
            this.components = new System.ComponentModel.Container();
            this.stocksDataGrid = new System.Windows.Forms.DataGridView();
            this.stockIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockInitiationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stocksDataGrid
            // 
            this.stocksDataGrid.AllowUserToAddRows = false;
            this.stocksDataGrid.AllowUserToDeleteRows = false;
            this.stocksDataGrid.AutoGenerateColumns = false;
            this.stocksDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stocksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stockIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.stockInitiationDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.stocksDataGrid.DataSource = this.stockBindingSource;
            this.stocksDataGrid.Location = new System.Drawing.Point(13, 13);
            this.stocksDataGrid.Name = "stocksDataGrid";
            this.stocksDataGrid.ReadOnly = true;
            this.stocksDataGrid.Size = new System.Drawing.Size(686, 266);
            this.stocksDataGrid.TabIndex = 0;
            // 
            // stockIDDataGridViewTextBoxColumn
            // 
            this.stockIDDataGridViewTextBoxColumn.DataPropertyName = "Stock_ID";
            this.stockIDDataGridViewTextBoxColumn.HeaderText = "Stock ID";
            this.stockIDDataGridViewTextBoxColumn.Name = "stockIDDataGridViewTextBoxColumn";
            this.stockIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.stockIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "_details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "Details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            this.detailsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockInitiationDateDataGridViewTextBoxColumn
            // 
            this.stockInitiationDateDataGridViewTextBoxColumn.DataPropertyName = "StockInitiation_Date";
            this.stockInitiationDateDataGridViewTextBoxColumn.HeaderText = "Stock Initiation Date";
            this.stockInitiationDateDataGridViewTextBoxColumn.Name = "stockInitiationDateDataGridViewTextBoxColumn";
            this.stockInitiationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "_Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost (Per item)";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(entityLayer.stock);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(586, 307);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 42);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // currentStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 366);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.stocksDataGrid);
            this.Name = "currentStocks";
            this.Text = "Current Stocks";
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView stocksDataGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockInitiationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource stockBindingSource;
    }
}