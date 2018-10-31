using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginUser : Form
    {
        User.UserHome userHome;
        public LoginUser(User.UserHome userHome)
        {
            InitializeComponent();
            this.userHome = userHome;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           string uname= txtUsername.Text;
            string psw = txtPassword.Text;
           Entity.User userTemp= BUS.H_User.userBUS.getUser(uname, psw);
            if (userTemp == null)
            {
                MessageBox.Show("Uname or psw is incorrect");
            }
            else
            {
                MessageBox.Show("Login successful !!");

                this.Dispose();
                userHome.user = userTemp;
                userHome.setBtnHistoryEnable(true);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
