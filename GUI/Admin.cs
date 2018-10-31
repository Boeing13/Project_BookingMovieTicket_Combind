using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_BookingTicket
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ManageMovie.Instance))
            {
                panel1.Controls.Add(ManageMovie.Instance);
                ManageMovie.Instance.Dock = DockStyle.Fill;
                ManageMovie.Instance.BringToFront();
            }
            else
                ManageMovie.Instance.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(ManageUser.Instance))
            {
                panel1.Controls.Add(ManageUser.Instance);
                ManageUser.Instance.Dock = DockStyle.Fill;
                ManageUser.Instance.BringToFront();
            }
            else
                ManageUser.Instance.BringToFront();
        }
    }
}
