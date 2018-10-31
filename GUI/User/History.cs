using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.User
{
    public partial class History : Form
    {
        UserHome userHome;
        public History(UserHome userHome)
        {
            InitializeComponent();
            this.userHome = userHome;
        }

        private void History_Load(object sender, EventArgs e)
        {
          DataTable dt=  BUS.H_MovieBus.movieBUS.getBookingHistory(userHome.user.UserID);
            if (dt.Rows.Count > 0)
            {
                dgvOrderHistory.Visible = true;
                msg.Visible = false;
                dgvOrderHistory.DataSource = dt;
            }
            
        }
    }
}
