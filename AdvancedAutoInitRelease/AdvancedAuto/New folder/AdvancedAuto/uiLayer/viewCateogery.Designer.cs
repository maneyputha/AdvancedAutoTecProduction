namespace uiLayer
{
    partial class viewCateogery
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
            this.categoryDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryDataGrid
            // 
            this.categoryDataGrid.AllowUserToAddRows = false;
            this.categoryDataGrid.AllowUserToDeleteRows = false;
            this.categoryDataGrid.AutoGenerateColumns = false;
            this.categoryDataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.categoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.itemCategoryNameDataGridViewTextBoxColumn,
            this.itemCategoryDescriptionDataGridViewTextBoxColumn});
            this.categoryDataGrid.DataSource = this.itemCategoryBindingSource;
            this.categoryDataGrid.Location = new System.Drawing.Point(12, 12);
            this.categoryDataGrid.Name = "categoryDataGrid";
            this.categoryDataGrid.Size = new System.Drawing.Size(635, 269);
            this.categoryDataGrid.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Item_Category_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // itemCategoryNameDataGridViewTextBoxColumn
            // 
            this.itemCategoryNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Category_Name";
            this.itemCategoryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.itemCategoryNameDataGridViewTextBoxColumn.Name = "itemCategoryNameDataGridViewTextBoxColumn";
            // 
            // itemCategoryDescriptionDataGridViewTextBoxColumn
            // 
            this.itemCategoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item_Category_Description";
            this.itemCategoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.itemCategoryDescriptionDataGridViewTextBoxColumn.Name = "itemCategoryDescriptionDataGridViewTextBoxColumn";
            // 
            // itemCategoryBindingSource
            // 
            this.itemCategoryBindingSource.DataSource = typeof(entityLayer.itemCategory);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Enabled = false;
            this.deleteBtn.Location = new System.Drawing.Point(534, 304);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(113, 42);
            this.deleteBtn.TabIndex = 45;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Visible = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // viewCateogery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 358);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.categoryDataGrid);
            this.Name = "viewCateogery";
            this.Text = "View Cateogery";
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView categoryDataGrid;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.BindingSource itemCategoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCategoryDescriptionDataGridViewTextBoxColumn;
    }
}