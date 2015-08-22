namespace uiLayer
{
    partial class viewBill
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
            this.billingItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billingGrid = new System.Windows.Forms.DataGridView();
            this.cde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBillID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCustNme = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCustTel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCarNo = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDte = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ibiUsrNme = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billingItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // billingItemBindingSource
            // 
            this.billingItemBindingSource.DataSource = typeof(entityLayer.billingItem);
            // 
            // billingGrid
            // 
            this.billingGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cde,
            this.nme,
            this.price,
            this.qty,
            this.Total});
            this.billingGrid.Location = new System.Drawing.Point(12, 118);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.Size = new System.Drawing.Size(694, 254);
            this.billingGrid.TabIndex = 0;
            this.billingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cde
            // 
            this.cde.HeaderText = "Code";
            this.cde.Name = "cde";
            // 
            // nme
            // 
            this.nme.HeaderText = "Name";
            this.nme.Name = "nme";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // qty
            // 
            this.qty.HeaderText = "Quantity";
            this.qty.Name = "qty";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Bill ID: ";
            // 
            // lblBillID
            // 
            this.lblBillID.AutoSize = true;
            this.lblBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillID.Location = new System.Drawing.Point(141, 9);
            this.lblBillID.Name = "lblBillID";
            this.lblBillID.Size = new System.Drawing.Size(53, 18);
            this.lblBillID.TabIndex = 28;
            this.lblBillID.Text = "Bill ID: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Customer Name: ";
            // 
            // lblCustNme
            // 
            this.lblCustNme.AutoSize = true;
            this.lblCustNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustNme.Location = new System.Drawing.Point(141, 36);
            this.lblCustNme.Name = "lblCustNme";
            this.lblCustNme.Size = new System.Drawing.Size(126, 18);
            this.lblCustNme.TabIndex = 30;
            this.lblCustNme.Text = "Customer Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Customer Tel: ";
            // 
            // lblCustTel
            // 
            this.lblCustTel.AutoSize = true;
            this.lblCustTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTel.Location = new System.Drawing.Point(141, 65);
            this.lblCustTel.Name = "lblCustTel";
            this.lblCustTel.Size = new System.Drawing.Size(106, 18);
            this.lblCustTel.TabIndex = 32;
            this.lblCustTel.Text = "Customer Tel: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(439, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 18);
            this.label7.TabIndex = 33;
            this.label7.Text = "Vehical No.:";
            // 
            // lblCarNo
            // 
            this.lblCarNo.AutoSize = true;
            this.lblCarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarNo.Location = new System.Drawing.Point(532, 9);
            this.lblCarNo.Name = "lblCarNo";
            this.lblCarNo.Size = new System.Drawing.Size(87, 18);
            this.lblCarNo.TabIndex = 34;
            this.lblCarNo.Text = "Vehical No.:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(479, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 35;
            this.label9.Text = "Date: ";
            // 
            // lblDte
            // 
            this.lblDte.AutoSize = true;
            this.lblDte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDte.Location = new System.Drawing.Point(532, 36);
            this.lblDte.Name = "lblDte";
            this.lblDte.Size = new System.Drawing.Size(39, 18);
            this.lblDte.TabIndex = 36;
            this.lblDte.Text = "Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Username: ";
            // 
            // ibiUsrNme
            // 
            this.ibiUsrNme.AutoSize = true;
            this.ibiUsrNme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibiUsrNme.Location = new System.Drawing.Point(532, 65);
            this.ibiUsrNme.Name = "ibiUsrNme";
            this.ibiUsrNme.Size = new System.Drawing.Size(77, 18);
            this.ibiUsrNme.TabIndex = 38;
            this.ibiUsrNme.Text = "Username";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(621, 398);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(28, 18);
            this.lblTotal.TabIndex = 39;
            this.lblTotal.Text = "0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 40;
            this.label1.Text = "Total (Rs.):";
            // 
            // viewBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.ibiUsrNme);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblDte);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCarNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCustTel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustNme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBillID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.billingGrid);
            this.Name = "viewBill";
            this.Text = "viewBill";
            this.Load += new System.EventHandler(this.viewBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billingItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource billingItemBindingSource;
        private System.Windows.Forms.DataGridView billingGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn cde;
        private System.Windows.Forms.DataGridViewTextBoxColumn nme;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBillID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustNme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCustTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCarNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ibiUsrNme;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
    }
}