namespace uiLayer
{
    partial class AddCatagory
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
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCatDsc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddCatagory = new System.Windows.Forms.Button();
            this.catnameVerify = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(165, 9);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(342, 20);
            this.txtCatName.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Catagory Name";
            // 
            // txtCatDsc
            // 
            this.txtCatDsc.Location = new System.Drawing.Point(165, 39);
            this.txtCatDsc.Multiline = true;
            this.txtCatDsc.Name = "txtCatDsc";
            this.txtCatDsc.Size = new System.Drawing.Size(342, 157);
            this.txtCatDsc.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Catagory Description";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(253, 211);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(124, 54);
            this.btnClear.TabIndex = 32;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddCatagory
            // 
            this.btnAddCatagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCatagory.Location = new System.Drawing.Point(383, 211);
            this.btnAddCatagory.Name = "btnAddCatagory";
            this.btnAddCatagory.Size = new System.Drawing.Size(124, 54);
            this.btnAddCatagory.TabIndex = 31;
            this.btnAddCatagory.Text = "Add";
            this.btnAddCatagory.UseVisualStyleBackColor = true;
            this.btnAddCatagory.Click += new System.EventHandler(this.btnAddCatagory_Click);
            // 
            // catnameVerify
            // 
            this.catnameVerify.AutoSize = true;
            this.catnameVerify.ForeColor = System.Drawing.Color.Red;
            this.catnameVerify.Location = new System.Drawing.Point(513, 12);
            this.catnameVerify.Name = "catnameVerify";
            this.catnameVerify.Size = new System.Drawing.Size(11, 13);
            this.catnameVerify.TabIndex = 36;
            this.catnameVerify.Text = "*";
            this.catnameVerify.Visible = false;
            // 
            // AddCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 285);
            this.Controls.Add(this.catnameVerify);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddCatagory);
            this.Controls.Add(this.txtCatDsc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.label4);
            this.Name = "AddCatagory";
            this.Text = "AddCatagory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCatDsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddCatagory;
        private System.Windows.Forms.Label catnameVerify;
    }
}