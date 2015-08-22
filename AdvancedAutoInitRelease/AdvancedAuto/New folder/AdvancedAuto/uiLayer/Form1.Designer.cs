namespace uiLayer
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsrname = new System.Windows.Forms.TextBox();
            this.txtPwrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.loginVerifyMessage = new System.Windows.Forms.Label();
            this.usernameVerifyMessage = new System.Windows.Forms.Label();
            this.passwordVerifyMessage = new System.Windows.Forms.Label();
            this.lblserial = new System.Windows.Forms.Label();
            this.appSerial = new System.Windows.Forms.TextBox();
            this.validateSerial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Advanced Auto Tec - Motor Work";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Username:";
            // 
            // txtUsrname
            // 
            this.txtUsrname.Location = new System.Drawing.Point(27, 66);
            this.txtUsrname.Name = "txtUsrname";
            this.txtUsrname.Size = new System.Drawing.Size(523, 20);
            this.txtUsrname.TabIndex = 3;
            // 
            // txtPwrd
            // 
            this.txtPwrd.Location = new System.Drawing.Point(27, 113);
            this.txtPwrd.Name = "txtPwrd";
            this.txtPwrd.PasswordChar = '*';
            this.txtPwrd.Size = new System.Drawing.Size(523, 20);
            this.txtPwrd.TabIndex = 5;
            this.txtPwrd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginVerifyMessage
            // 
            this.loginVerifyMessage.AutoSize = true;
            this.loginVerifyMessage.ForeColor = System.Drawing.Color.Red;
            this.loginVerifyMessage.Location = new System.Drawing.Point(191, 150);
            this.loginVerifyMessage.Name = "loginVerifyMessage";
            this.loginVerifyMessage.Size = new System.Drawing.Size(128, 13);
            this.loginVerifyMessage.TabIndex = 7;
            this.loginVerifyMessage.Text = "* Invalid User Credentials ";
            this.loginVerifyMessage.Visible = false;
            // 
            // usernameVerifyMessage
            // 
            this.usernameVerifyMessage.AutoSize = true;
            this.usernameVerifyMessage.ForeColor = System.Drawing.Color.Red;
            this.usernameVerifyMessage.Location = new System.Drawing.Point(557, 72);
            this.usernameVerifyMessage.Name = "usernameVerifyMessage";
            this.usernameVerifyMessage.Size = new System.Drawing.Size(11, 13);
            this.usernameVerifyMessage.TabIndex = 8;
            this.usernameVerifyMessage.Text = "*";
            this.usernameVerifyMessage.Visible = false;
            // 
            // passwordVerifyMessage
            // 
            this.passwordVerifyMessage.AutoSize = true;
            this.passwordVerifyMessage.ForeColor = System.Drawing.Color.Red;
            this.passwordVerifyMessage.Location = new System.Drawing.Point(557, 119);
            this.passwordVerifyMessage.Name = "passwordVerifyMessage";
            this.passwordVerifyMessage.Size = new System.Drawing.Size(11, 13);
            this.passwordVerifyMessage.TabIndex = 9;
            this.passwordVerifyMessage.Text = "*";
            this.passwordVerifyMessage.Visible = false;
            // 
            // lblserial
            // 
            this.lblserial.AutoSize = true;
            this.lblserial.ForeColor = System.Drawing.Color.Red;
            this.lblserial.Location = new System.Drawing.Point(57, 245);
            this.lblserial.Name = "lblserial";
            this.lblserial.Size = new System.Drawing.Size(160, 13);
            this.lblserial.TabIndex = 10;
            this.lblserial.Text = "*Please enter a valid serial key  :";
            this.lblserial.Visible = false;
            // 
            // appSerial
            // 
            this.appSerial.Location = new System.Drawing.Point(220, 242);
            this.appSerial.Name = "appSerial";
            this.appSerial.Size = new System.Drawing.Size(235, 20);
            this.appSerial.TabIndex = 11;
            this.appSerial.Visible = false;
            // 
            // validateSerial
            // 
            this.validateSerial.Location = new System.Drawing.Point(461, 239);
            this.validateSerial.Name = "validateSerial";
            this.validateSerial.Size = new System.Drawing.Size(89, 23);
            this.validateSerial.TabIndex = 12;
            this.validateSerial.Text = "Validate";
            this.validateSerial.UseVisualStyleBackColor = true;
            this.validateSerial.Visible = false;
            this.validateSerial.Click += new System.EventHandler(this.validateSerial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 283);
            this.Controls.Add(this.validateSerial);
            this.Controls.Add(this.appSerial);
            this.Controls.Add(this.lblserial);
            this.Controls.Add(this.passwordVerifyMessage);
            this.Controls.Add(this.usernameVerifyMessage);
            this.Controls.Add(this.loginVerifyMessage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPwrd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUsrname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsrname;
        private System.Windows.Forms.TextBox txtPwrd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginVerifyMessage;
        private System.Windows.Forms.Label usernameVerifyMessage;
        private System.Windows.Forms.Label passwordVerifyMessage;
        private System.Windows.Forms.Label lblserial;
        private System.Windows.Forms.TextBox appSerial;
        private System.Windows.Forms.Button validateSerial;
    }
}

