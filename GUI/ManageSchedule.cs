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
    public partial class ManageSchedule : UserControl
    {
        ScheduleBUS sbus = new ScheduleBUS();

        public ManageSchedule()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            dgvSchedule.DataSource = sbus.GetAllSchedule();
        }

        public void ManageSchedule_Load(object sender, EventArgs e)
        {

            LoadData();
            
                    
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            AddSchedule add = new AddSchedule(this);
            add.ShowDialog();
        }

        private void btnUpdateSchedule_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedCells.Count > 0)
            {           
                UpdateSchedule detail = new UpdateSchedule(this);
                detail.ShowDialog();
            }
        }

        private void dgvSchedule_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            DeleteSchedule delete = new DeleteSchedule(this);
            delete.ShowDialog();
        }
    }
}
