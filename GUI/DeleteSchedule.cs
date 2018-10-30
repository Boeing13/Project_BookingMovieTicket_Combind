using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class DeleteSchedule : Form
    {
        ManageSchedule parent;
        ScheduleBUS sbus = new ScheduleBUS();
        private int roomID;
        private int hourID;
        private string date;

        public DeleteSchedule()
        {
            InitializeComponent();
        }

        public DeleteSchedule(ManageSchedule parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void DeleteSchedule_Load(object sender, EventArgs e)
        {
            int rowindex = parent.dgvSchedule.CurrentCell.RowIndex;
            lblRoom.Text = parent.dgvSchedule.Rows[rowindex].Cells[0].Value.ToString();
            lblTime.Text = parent.dgvSchedule.Rows[rowindex].Cells[1].Value.ToString();
            lblMovie.Text = parent.dgvSchedule.Rows[rowindex].Cells[2].Value.ToString();
            lblDate.Text = Convert.ToDateTime(parent.dgvSchedule.Rows[rowindex].Cells[3].Value.ToString()).ToString("yyyy-MM-dd");
            lblSeat.Text = parent.dgvSchedule.Rows[rowindex].Cells[4].Value.ToString();
       
            roomID = sbus.GetRoomID(lblRoom.Text);
            hourID = sbus.GetHourID(lblTime.Text);
            date = lblDate.Text;
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
               
                int state = sbus.DeleteSchedule(roomID, hourID, date);
                if (state == 1)
                {

                    SuccessNotify notify = new SuccessNotify();
                    notify.lblMessage.Text = "Delete schedule successfully!";
                    notify.ShowDialog();
                }
                else
                {
                    SuccessNotify notify = new SuccessNotify();
                    notify.lblMessage.Text = "Delete schedule failed!";
                    notify.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            parent.LoadData();
            this.Close();
        }
    }
}
