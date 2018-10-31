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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        public Boolean isExitedUName(string uname)
        {
            return BUS.H_User.userBUS.isExitedUName(uname);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           string uname= txtUName.Text;
            string tel = txtTel.Text;
            string address = txtAddress.Text;
            string psw = txtPass.Text;
            string cfpsw = txtConPass.Text;
            string fname = txtFullName.Text;
            if (uname.Length <= 0 || tel.Length <= 0 || address.Length <= 0 || psw.Length <= 0 || cfpsw.Length <= 0)
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            if (psw.Length < 5)
            {
                MessageBox.Show("Password length must >= 5");
                return;
            }
            if (!psw.Equals(cfpsw))
            {
                MessageBox.Show("Confimation password is not equal password");
                return;
            }
            if (isExitedUName(uname))
            {
                MessageBox.Show("This user name is exited");
                return;
            }
           int result= BUS.H_User.userBUS.insertUser(uname, psw, fname, tel, address);
            if (result > 0)
            {
                MessageBox.Show("Successful");
            }


        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtFullName.Text, "^[a-zA-Z ]"))
            {
                MessageBox.Show("This textbox accepts only alphabetical characters");
                txtFullName.Text = "";
            }
        }

        private void txtFullName_KeyPress(object sender, KeyPressEventArgs e)
        {
           char temp= e.KeyChar;
            if(temp>=65&&temp<=90 || temp >= 97 && temp <= 122 || temp==8 || temp == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
