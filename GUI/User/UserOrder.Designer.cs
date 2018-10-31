namespace GUI
{
    partial class UserOrder
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
            this.lbMName = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.Label();
            this.lbHour = new System.Windows.Forms.Label();
            this.lbUName = new System.Windows.Forms.Label();
            this.lbTel = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbType = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMName
            // 
            this.lbMName.AutoSize = true;
            this.lbMName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMName.Location = new System.Drawing.Point(21, 28);
            this.lbMName.Name = "lbMName";
            this.lbMName.Size = new System.Drawing.Size(82, 17);
            this.lbMName.TabIndex = 0;
            this.lbMName.Text = "MovieName";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(21, 131);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(45, 17);
            this.lbRoom.TabIndex = 1;
            this.lbRoom.Text = "Room";
            // 
            // lbTickets
            // 
            this.lbTickets.AutoSize = true;
            this.lbTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTickets.Location = new System.Drawing.Point(21, 171);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(86, 17);
            this.lbTickets.TabIndex = 2;
            this.lbTickets.Text = "NoOfTickets";
            // 
            // lbHour
            // 
            this.lbHour.AutoSize = true;
            this.lbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHour.Location = new System.Drawing.Point(21, 62);
            this.lbHour.Name = "lbHour";
            this.lbHour.Size = new System.Drawing.Size(39, 17);
            this.lbHour.TabIndex = 3;
            this.lbHour.Text = "Hour";
            // 
            // lbUName
            // 
            this.lbUName.AutoSize = true;
            this.lbUName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUName.Location = new System.Drawing.Point(40, 20);
            this.lbUName.Name = "lbUName";
            this.lbUName.Size = new System.Drawing.Size(105, 25);
            this.lbUName.TabIndex = 4;
            this.lbUName.Text = "UserName";
            // 
            // lbTel
            // 
            this.lbTel.AutoSize = true;
            this.lbTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTel.Location = new System.Drawing.Point(40, 71);
            this.lbTel.Name = "lbTel";
            this.lbTel.Size = new System.Drawing.Size(40, 25);
            this.lbTel.TabIndex = 5;
            this.lbTel.Text = "Tel";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(37, 118);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(85, 25);
            this.lbAddress.TabIndex = 8;
            this.lbAddress.Text = "Address";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(393, 424);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(159, 44);
            this.btnShow.TabIndex = 23;
            this.btnShow.Text = "Order";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(245, 175);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(31, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbType);
            this.groupBox1.Controls.Add(this.lbMName);
            this.groupBox1.Controls.Add(this.lbTotal);
            this.groupBox1.Controls.Add(this.lbTickets);
            this.groupBox1.Controls.Add(this.lbHour);
            this.groupBox1.Controls.Add(this.lbRoom);
            this.groupBox1.Location = new System.Drawing.Point(42, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 213);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detail";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.Location = new System.Drawing.Point(21, 95);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 17);
            this.lbType.TabIndex = 5;
            this.lbType.Text = "Type";
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.lbTel);
            this.Controls.Add(this.lbUName);
            this.Name = "UserOrder";
            this.Text = "UserOrder";
            this.Load += new System.EventHandler(this.UserOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMName;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbTickets;
        private System.Windows.Forms.Label lbHour;
        private System.Windows.Forms.Label lbUName;
        private System.Windows.Forms.Label lbTel;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbType;
    }
}