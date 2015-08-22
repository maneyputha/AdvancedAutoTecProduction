namespace uiLayer
{
    partial class AddStock
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.NumericUpDown();
            this.pcodeVerify = new System.Windows.Forms.Label();
            this.costVerify = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Quantity";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(155, 12);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(319, 20);
            this.txtProductCode.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product Code";
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(155, 42);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(319, 87);
            this.txtDetails.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Stock Added Date";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(220, 237);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 54);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(350, 237);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 54);
            this.btnAddProduct.TabIndex = 28;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Cost";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(155, 169);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(319, 20);
            this.txtCost.TabIndex = 30;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(155, 136);
            this.txtQty.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(319, 20);
            this.txtQty.TabIndex = 46;
            this.txtQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pcodeVerify
            // 
            this.pcodeVerify.AutoSize = true;
            this.pcodeVerify.ForeColor = System.Drawing.Color.Red;
            this.pcodeVerify.Location = new System.Drawing.Point(480, 15);
            this.pcodeVerify.Name = "pcodeVerify";
            this.pcodeVerify.Size = new System.Drawing.Size(11, 13);
            this.pcodeVerify.TabIndex = 47;
            this.pcodeVerify.Text = "*";
            this.pcodeVerify.Visible = false;
            // 
            // costVerify
            // 
            this.costVerify.AutoSize = true;
            this.costVerify.ForeColor = System.Drawing.Color.Red;
            this.costVerify.Location = new System.Drawing.Point(480, 172);
            this.costVerify.Name = "costVerify";
            this.costVerify.Size = new System.Drawing.Size(11, 13);
            this.costVerify.TabIndex = 48;
            this.costVerify.Text = "*";
            this.costVerify.Visible = false;
            // 
            // AddStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 307);
            this.Controls.Add(this.costVerify);
            this.Controls.Add(this.pcodeVerify);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStock";
            this.Text = "AddStock";
            ((System.ComponentModel.ISupportInitialize)(this.txtQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.NumericUpDown txtQty;
        private System.Windows.Forms.Label pcodeVerify;
        private System.Windows.Forms.Label costVerify;
    }
}