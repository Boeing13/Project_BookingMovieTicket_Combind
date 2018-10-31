namespace PROJECT_BookingTicket
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnMovie = new System.Windows.Forms.ToolStripButton();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMovie,
            this.btnUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(858, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnMovie
            // 
            this.btnMovie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMovie.Image = ((System.Drawing.Image)(resources.GetObject("btnMovie.Image")));
            this.btnMovie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(23, 22);
            this.btnMovie.Text = "toolStripButton1";
            this.btnMovie.Click += new System.EventHandler(this.btnMovie_Click);
            // 
            // btnUser
            // 
            this.btnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 22);
            this.btnUser.Text = "toolStripButton1";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 466);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BankGothic Md BT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to booking ticket Management";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Admin";
            this.Text = "Administrator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnMovie;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

