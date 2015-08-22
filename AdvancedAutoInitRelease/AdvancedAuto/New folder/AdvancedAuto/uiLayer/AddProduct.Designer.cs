namespace uiLayer
{
    partial class AddProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductDesc = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductPrc = new System.Windows.Forms.TextBox();
            this.combProCat = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtProductMake = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pcodeVerify = new System.Windows.Forms.Label();
            this.pnameVerify = new System.Windows.Forms.Label();
            this.ppriceVerify = new System.Windows.Forms.Label();
            this.cmbCatVerify = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrdQty = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdQty)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Product Catagory";
            // 
            // txtProductDesc
            // 
            this.txtProductDesc.Location = new System.Drawing.Point(159, 149);
            this.txtProductDesc.Multiline = true;
            this.txtProductDesc.Name = "txtProductDesc";
            this.txtProductDesc.Size = new System.Drawing.Size(355, 68);
            this.txtProductDesc.TabIndex = 5;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(159, 13);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(355, 20);
            this.txtProductCode.TabIndex = 6;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(159, 48);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(355, 20);
            this.txtProductName.TabIndex = 7;
            // 
            // txtProductPrc
            // 
            this.txtProductPrc.Location = new System.Drawing.Point(159, 267);
            this.txtProductPrc.Name = "txtProductPrc";
            this.txtProductPrc.Size = new System.Drawing.Size(355, 20);
            this.txtProductPrc.TabIndex = 8;
            // 
            // combProCat
            // 
            this.combProCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.combProCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combProCat.FormattingEnabled = true;
            this.combProCat.Location = new System.Drawing.Point(159, 299);
            this.combProCat.Name = "combProCat";
            this.combProCat.Size = new System.Drawing.Size(228, 21);
            this.combProCat.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(389, 344);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(124, 54);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(259, 344);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 54);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtProductMake
            // 
            this.txtProductMake.Location = new System.Drawing.Point(159, 84);
            this.txtProductMake.Name = "txtProductMake";
            this.txtProductMake.Size = new System.Drawing.Size(355, 20);
            this.txtProductMake.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Product Make";
            // 
            // txtProductModel
            // 
            this.txtProductModel.Location = new System.Drawing.Point(158, 117);
            this.txtProductModel.Name = "txtProductModel";
            this.txtProductModel.Size = new System.Drawing.Size(355, 20);
            this.txtProductModel.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Product Model";
            // 
            // pcodeVerify
            // 
            this.pcodeVerify.AutoSize = true;
            this.pcodeVerify.ForeColor = System.Drawing.Color.Red;
            this.pcodeVerify.Location = new System.Drawing.Point(520, 18);
            this.pcodeVerify.Name = "pcodeVerify";
            this.pcodeVerify.Size = new System.Drawing.Size(11, 13);
            this.pcodeVerify.TabIndex = 37;
            this.pcodeVerify.Text = "*";
            this.pcodeVerify.Visible = false;
            // 
            // pnameVerify
            // 
            this.pnameVerify.AutoSize = true;
            this.pnameVerify.ForeColor = System.Drawing.Color.Red;
            this.pnameVerify.Location = new System.Drawing.Point(520, 51);
            this.pnameVerify.Name = "pnameVerify";
            this.pnameVerify.Size = new System.Drawing.Size(11, 13);
            this.pnameVerify.TabIndex = 38;
            this.pnameVerify.Text = "*";
            this.pnameVerify.Visible = false;
            // 
            // ppriceVerify
            // 
            this.ppriceVerify.AutoSize = true;
            this.ppriceVerify.ForeColor = System.Drawing.Color.Red;
            this.ppriceVerify.Location = new System.Drawing.Point(520, 274);
            this.ppriceVerify.Name = "ppriceVerify";
            this.ppriceVerify.Size = new System.Drawing.Size(11, 13);
            this.ppriceVerify.TabIndex = 39;
            this.ppriceVerify.Text = "*";
            this.ppriceVerify.Visible = false;
            // 
            // cmbCatVerify
            // 
            this.cmbCatVerify.AutoSize = true;
            this.cmbCatVerify.ForeColor = System.Drawing.Color.Red;
            this.cmbCatVerify.Location = new System.Drawing.Point(393, 303);
            this.cmbCatVerify.Name = "cmbCatVerify";
            this.cmbCatVerify.Size = new System.Drawing.Size(121, 13);
            this.cmbCatVerify.TabIndex = 43;
            this.cmbCatVerify.Text = "*Please Select Category";
            this.cmbCatVerify.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 18);
            this.label8.TabIndex = 44;
            this.label8.Text = "Product Quantity";
            // 
            // txtPrdQty
            // 
            this.txtPrdQty.Location = new System.Drawing.Point(158, 235);
            this.txtPrdQty.Maximum = new decimal(new int[] {
            268435455,
            1042612833,
            542101086,
            0});
            this.txtPrdQty.Name = "txtPrdQty";
            this.txtPrdQty.Size = new System.Drawing.Size(355, 20);
            this.txtPrdQty.TabIndex = 45;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 415);
            this.Controls.Add(this.txtPrdQty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbCatVerify);
            this.Controls.Add(this.ppriceVerify);
            this.Controls.Add(this.pnameVerify);
            this.Controls.Add(this.pcodeVerify);
            this.Controls.Add(this.txtProductModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.combProCat);
            this.Controls.Add(this.txtProductPrc);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.txtProductDesc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrdQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductDesc;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductPrc;
        private System.Windows.Forms.ComboBox combProCat;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtProductMake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductModel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label pcodeVerify;
        private System.Windows.Forms.Label pnameVerify;
        private System.Windows.Forms.Label ppriceVerify;
        private System.Windows.Forms.Label cmbCatVerify;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtPrdQty;
    }
}