namespace uiLayer
{
    partial class BillDetailedView
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
            this.detailedBill = new System.Windows.Forms.DataGridView();
            this.billingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detailedBill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // detailedBill
            // 
            this.detailedBill.AllowUserToAddRows = false;
            this.detailedBill.AllowUserToDeleteRows = false;
            this.detailedBill.AutoGenerateColumns = false;
            this.detailedBill.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.detailedBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailedBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billItemIdDataGridViewTextBoxColumn,
            this.serviceDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.quantiyDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.detailedBill.DataSource = this.billingItemBindingSource;
            this.detailedBill.Location = new System.Drawing.Point(13, 13);
            this.detailedBill.Name = "detailedBill";
            this.detailedBill.ReadOnly = true;
            this.detailedBill.Size = new System.Drawing.Size(636, 279);
            this.detailedBill.TabIndex = 0;
            // 
            // billingItemBindingSource
            // 
            this.billingItemBindingSource.DataSource = typeof(entityLayer.billingItem);
            // 
            // billItemIdDataGridViewTextBoxColumn
            // 
            this.billItemIdDataGridViewTextBoxColumn.DataPropertyName = "BillItemId";
            this.billItemIdDataGridViewTextBoxColumn.HeaderText = "Bill ItemcId";
            this.billItemIdDataGridViewTextBoxColumn.Name = "billItemIdDataGridViewTextBoxColumn";
            this.billItemIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.billItemIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantiyDataGridViewTextBoxColumn
            // 
            this.quantiyDataGridViewTextBoxColumn.DataPropertyName = "Quantiy";
            this.quantiyDataGridViewTextBoxColumn.HeaderText = "Quantiy";
            this.quantiyDataGridViewTextBoxColumn.Name = "quantiyDataGridViewTextBoxColumn";
            this.quantiyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // BillDetailedView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 388);
            this.Controls.Add(this.detailedBill);
            this.Name = "BillDetailedView";
            this.Text = "Bill Detailed View";
            ((System.ComponentModel.ISupportInitialize)(this.detailedBill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView detailedBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn billItemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource billingItemBindingSource;
    }
}