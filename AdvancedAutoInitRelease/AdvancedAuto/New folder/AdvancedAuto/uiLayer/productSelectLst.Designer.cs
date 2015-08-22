namespace uiLayer
{
    partial class productSelectLst
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
            this.lstBxSearchItms1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxSearchItms1
            // 
            this.lstBxSearchItms1.Location = new System.Drawing.Point(13, 13);
            this.lstBxSearchItms1.Name = "lstBxSearchItms1";
            this.lstBxSearchItms1.Size = new System.Drawing.Size(328, 240);
            this.lstBxSearchItms1.TabIndex = 0;
            this.lstBxSearchItms1.UseCompatibleStateImageBehavior = false;
            this.lstBxSearchItms1.SelectedIndexChanged += new System.EventHandler(this.lstBxSearchItms1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // productSelectLst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstBxSearchItms1);
            this.Name = "productSelectLst";
            this.Text = "productSelectLst";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstBxSearchItms1;
        private System.Windows.Forms.Button button1;
    }
}