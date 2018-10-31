namespace GUI
{
    partial class UserDetailTicket
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
            this.lbName = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.nudSeat = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbTypeMovie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(31, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(165, 31);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Movie Name";
            this.lbName.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(37, 104);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(121, 21);
            this.cbHour.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(16, 280);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(159, 44);
            this.btnOrder.TabIndex = 22;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(37, 151);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 24;
            // 
            // nudSeat
            // 
            this.nudSeat.Location = new System.Drawing.Point(41, 214);
            this.nudSeat.Name = "nudSeat";
            this.nudSeat.Size = new System.Drawing.Size(120, 20);
            this.nudSeat.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hour (h)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Number of ticket";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(226, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(226, 229);
            this.txtDescription.TabIndex = 29;
            // 
            // lbTypeMovie
            // 
            this.lbTypeMovie.AutoSize = true;
            this.lbTypeMovie.Location = new System.Drawing.Point(34, 60);
            this.lbTypeMovie.Name = "lbTypeMovie";
            this.lbTypeMovie.Size = new System.Drawing.Size(35, 13);
            this.lbTypeMovie.TabIndex = 30;
            this.lbTypeMovie.Text = "label4";
            // 
            // UserDetailTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 336);
            this.Controls.Add(this.lbTypeMovie);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudSeat);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.lbName);
            this.Name = "UserDetailTicket";
            this.Text = "UserDetailTicket";
            this.Load += new System.EventHandler(this.UserDetailTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSeat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.NumericUpDown nudSeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbTypeMovie;
    }
}