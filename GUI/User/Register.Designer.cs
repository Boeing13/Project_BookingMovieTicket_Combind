namespace GUI.User
{
    partial class Register
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
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(198, 70);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(193, 20);
            this.txtUName.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(198, 119);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(193, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tel";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(198, 223);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(193, 20);
            this.txtPass.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // txtConPass
            // 
            this.txtConPass.Location = new System.Drawing.Point(198, 279);
            this.txtConPass.Name = "txtConPass";
            this.txtConPass.PasswordChar = '*';
            this.txtConPass.Size = new System.Drawing.Size(193, 20);
            this.txtConPass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(198, 349);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(198, 166);
            this.txtTel.Mask = "(999) 000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(193, 20);
            this.txtTel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(198, 29);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(193, 20);
            this.txtFullName.TabIndex = 13;
            this.txtFullName.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtFullName;
    }
}