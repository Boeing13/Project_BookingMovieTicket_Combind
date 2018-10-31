using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;



namespace GUI
{
    public partial class ManageUser : UserControl
    {
        UserBUS ub = new UserBUS();
       
        public ManageUser()
        {
            InitializeComponent();
            
            
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = ub.GetAllUser();
                dgvUsers.DataSource = dt;
            }
            catch (Exception)
            {
            
            }
            
        }

        private void btnDetailUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedCells.Count > 0)
            {
                int rowindex = dgvUsers.CurrentCell.RowIndex;
                string id = dgvUsers.Rows[rowindex].Cells[0].Value.ToString();
                string name = dgvUsers.Rows[rowindex].Cells[1].Value.ToString();
                string phone = dgvUsers.Rows[rowindex].Cells[2].Value.ToString();
                string address = dgvUsers.Rows[rowindex].Cells[3].Value.ToString();
                CustomerDetail detail = new CustomerDetail(id, name, phone, address);
                detail.ShowDialog();
            }
            
        }
    }
}
