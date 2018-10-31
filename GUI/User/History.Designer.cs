namespace GUI.User
{
    partial class History
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
            this.dgvOrderHistory = new System.Windows.Forms.DataGridView();
            this.msg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrderHistory
            // 
            this.dgvOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderHistory.Location = new System.Drawing.Point(-2, 1);
            this.dgvOrderHistory.Name = "dgvOrderHistory";
            this.dgvOrderHistory.Size = new System.Drawing.Size(627, 299);
            this.dgvOrderHistory.TabIndex = 0;
            this.dgvOrderHistory.Visible = false;
            // 
            // msg
            // 
            this.msg.AutoSize = true;
            this.msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg.Location = new System.Drawing.Point(27, 20);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(212, 24);
            this.msg.TabIndex = 1;
            this.msg.Text = "Booking history is empty";
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 305);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.dgvOrderHistory);
            this.Name = "History";
            this.Text = "History";
            this.Load += new System.EventHandler(this.History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderHistory;
        private System.Windows.Forms.Label msg;
    }
}