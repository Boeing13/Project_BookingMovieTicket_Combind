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
    public partial class CustomerDetail : Form
    {

        public ManageUser customer;
        public string id;

        public CustomerDetail()
        {
            InitializeComponent();
        }
        public CustomerDetail(ManageUser customer, string id)
        {
            InitializeComponent();
            this.customer = customer;
            this.id = id;
        }

        public CustomerDetail(string id, string name, string phone, string address)
        {
            InitializeComponent();
            txtID.Text = id;
            txtName.Text = name;
            txtPhone.Text = phone;
            txtAddress.Text = address;

        }

        private void btnCloseDetailUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
