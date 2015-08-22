namespace uiLayer
{
    partial class viewSalesRprt
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
            this.datetPkrFrm = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTPkrTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cmbSrchBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPricelbl = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.salesReportGrid = new System.Windows.Forms.DataGridView();
            this.billIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBillBtn = new System.Windows.Forms.Button();
            this.viewBillBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datetPkrFrm
            // 
            this.datetPkrFrm.Location = new System.Drawing.Point(69, 54);
            this.datetPkrFrm.Name = "datetPkrFrm";
            this.datetPkrFrm.Size = new System.Drawing.Size(200, 20);
            this.datetPkrFrm.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "To";
            // 
            // dateTPkrTo
            // 
            this.dateTPkrTo.Location = new System.Drawing.Point(312, 54);
            this.dateTPkrTo.Name = "dateTPkrTo";
            this.dateTPkrTo.Size = new System.Drawing.Size(200, 20);
            this.dateTPkrTo.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(577, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(148, 66);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(69, 80);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(443, 20);
            this.searchBox.TabIndex = 24;
            // 
            // cmbSrchBy
            // 
            this.cmbSrchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSrchBy.FormattingEnabled = true;
            this.cmbSrchBy.Location = new System.Drawing.Point(103, 18);
            this.cmbSrchBy.Name = "cmbSrchBy";
            this.cmbSrchBy.Size = new System.Drawing.Size(409, 21);
            this.cmbSrchBy.TabIndex = 25;
            this.cmbSrchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSrchBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Search By:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(625, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Total Sales Value";
            // 
            // totalPricelbl
            // 
            this.totalPricelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalPricelbl.AutoSize = true;
            this.totalPricelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPricelbl.Location = new System.Drawing.Point(788, 425);
            this.totalPricelbl.Name = "totalPricelbl";
            this.totalPricelbl.Size = new System.Drawing.Size(44, 18);
            this.totalPricelbl.TabIndex = 29;
            this.totalPricelbl.Text = "00.00";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(437, 457);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 54);
            this.btnClear.TabIndex = 31;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 18);
            this.label10.TabIndex = 33;
            this.label10.Text = "Name";
            // 
            // salesReportGrid
            // 
            this.salesReportGrid.AllowUserToAddRows = false;
            this.salesReportGrid.AllowUserToDeleteRows = false;
            this.salesReportGrid.AutoGenerateColumns = false;
            this.salesReportGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesReportGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesReportGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billIdDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerTelDataGridViewTextBoxColumn,
            this.vehicleNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.salesReportGrid.DataSource = this.billBindingSource;
            this.salesReportGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salesReportGrid.Location = new System.Drawing.Point(20, 119);
            this.salesReportGrid.Name = "salesReportGrid";
            this.salesReportGrid.ReadOnly = true;
            this.salesReportGrid.Size = new System.Drawing.Size(840, 271);
            this.salesReportGrid.TabIndex = 34;
            // 
            // billIdDataGridViewTextBoxColumn
            // 
            this.billIdDataGridViewTextBoxColumn.DataPropertyName = "BillId";
            this.billIdDataGridViewTextBoxColumn.HeaderText = "Bill Id";
            this.billIdDataGridViewTextBoxColumn.Name = "billIdDataGridViewTextBoxColumn";
            this.billIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.billIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerTelDataGridViewTextBoxColumn
            // 
            this.customerTelDataGridViewTextBoxColumn.DataPropertyName = "CustomerTel";
            this.customerTelDataGridViewTextBoxColumn.HeaderText = "Customer Telephone";
            this.customerTelDataGridViewTextBoxColumn.Name = "customerTelDataGridViewTextBoxColumn";
            this.customerTelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleNoDataGridViewTextBoxColumn
            // 
            this.vehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleNo";
            this.vehicleNoDataGridViewTextBoxColumn.HeaderText = "Vehicle Number";
            this.vehicleNoDataGridViewTextBoxColumn.Name = "vehicleNoDataGridViewTextBoxColumn";
            this.vehicleNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataSource = typeof(entityLayer.bill);
            // 
            // deleteBillBtn
            // 
            this.deleteBillBtn.Enabled = false;
            this.deleteBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBillBtn.Location = new System.Drawing.Point(736, 457);
            this.deleteBillBtn.Name = "deleteBillBtn";
            this.deleteBillBtn.Size = new System.Drawing.Size(124, 54);
            this.deleteBillBtn.TabIndex = 35;
            this.deleteBillBtn.Text = "Delete";
            this.deleteBillBtn.UseVisualStyleBackColor = true;
            this.deleteBillBtn.Visible = false;
            this.deleteBillBtn.Click += new System.EventHandler(this.deleteBillBtn_Click);
            // 
            // viewBillBtn
            // 
            this.viewBillBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBillBtn.Location = new System.Drawing.Point(586, 457);
            this.viewBillBtn.Name = "viewBillBtn";
            this.viewBillBtn.Size = new System.Drawing.Size(124, 54);
            this.viewBillBtn.TabIndex = 36;
            this.viewBillBtn.Text = "View Bill";
            this.viewBillBtn.UseVisualStyleBackColor = true;
            this.viewBillBtn.Click += new System.EventHandler(this.viewBillBtn_Click);
            // 
            // viewSalesRprt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 534);
            this.Controls.Add(this.viewBillBtn);
            this.Controls.Add(this.deleteBillBtn);
            this.Controls.Add(this.salesReportGrid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.totalPricelbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbSrchBy);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTPkrTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetPkrFrm);
            this.Name = "viewSalesRprt";
            this.Text = "View Sales Reports";
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datetPkrFrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTPkrTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ComboBox cmbSrchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalPricelbl;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView salesReportGrid;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.Button deleteBillBtn;
        private System.Windows.Forms.Button viewBillBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}