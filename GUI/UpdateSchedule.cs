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
using Entity;

namespace GUI
{
    public partial class UpdateSchedule : Form
    {
        ScheduleBUS sbus = new ScheduleBUS();
        private ManageSchedule parent;
        private int roomID;
        private int hourID;
        private string date;
        private int movieID;      
        private int roomDK;
        private int hourDK;
        private string dateDK;
        public UpdateSchedule()
        {
            InitializeComponent();
        }


        public UpdateSchedule(ManageSchedule parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                int state = -1;
                if (Convert.ToInt32(txtSeat.Text) <= 0)
                {
                    DisplayFailNotify("Left seat must be possitive number");

                    return;
                }

                if (roomDK == roomID && hourDK == hourID && dateDK.Equals(date))
                {
                    int leftSeat = Convert.ToInt32(txtSeat.Text);
                    state = sbus.UpdateSeatAndMovie(leftSeat, movieID, roomDK, hourDK, dateDK);
                }
                else
                {
                    MessageBox.Show("roomDK " + roomDK + "\t" + roomID + 
                                    "hourDK " + hourDK + "\t" + hourID +
                                    "dateDK " + dateDK + "\t" + date);
                    Schedule schedule = new Schedule()
                    {

                        RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                        HourID = Convert.ToInt32(cmbHours.SelectedValue),
                        MovieID = Convert.ToInt32(cmbMovie.SelectedValue),
                        Date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"),
                        LeftSeat = Convert.ToInt32(txtSeat.Text)
                    };
                    state = sbus.UpdateSchedule(schedule, roomDK, hourDK, dateDK);
                }
               
                if (state == 1)
                {

                    SuccessNotify notify = new SuccessNotify();
                    notify.lblMessage.Text = "Update schedule successfully!";
                    notify.ShowDialog();
                }
            }
            catch (FormatException)
            {
                DisplayFailNotify("Left seat must be possitive number");

            }
            catch (Exception)
            {
                DisplayFailNotify("This schedule has already been used");

            }
            parent.LoadData();
        }

        private void UpdateSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMovie.DisplayMember = "title";
                cmbMovie.ValueMember = "movieID";
                cmbMovie.DataSource = sbus.GetAllMovies();

                cmbHours.DisplayMember = "time";
                cmbHours.ValueMember = "hourID";
                cmbHours.DataSource = sbus.GetAllHours();

                cmbRoom.DisplayMember = "name";
                cmbRoom.ValueMember = "roomID";
                cmbRoom.DataSource = sbus.GetAllRooms();

                
                int rowindex = parent.dgvSchedule.CurrentCell.RowIndex;
                roomDK = sbus.GetRoomID(parent.dgvSchedule.Rows[rowindex].Cells[0].Value.ToString());
                hourDK = sbus.GetHourID(parent.dgvSchedule.Rows[rowindex].Cells[1].Value.ToString());
                int movieID = sbus.GetMovieID(parent.dgvSchedule.Rows[rowindex].Cells[2].Value.ToString());
                dateDK = parent.dgvSchedule.Rows[rowindex].Cells[3].Value.ToString();
                string leftSeat = parent.dgvSchedule.Rows[rowindex].Cells[4].Value.ToString();

                cmbRoom.SelectedValue = roomDK;
                cmbHours.SelectedValue = hourDK;
                cmbMovie.SelectedValue = movieID;
                txtDate.Text = dateDK;
                txtSeat.Text = leftSeat;
                DateTime example = Convert.ToDateTime(dateDK);
                monthCalendar1.SetDate(example);          
                dateDK = monthCalendar1.SelectionRange.Start.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DisplayFailNotify(string str)
        {
            FailNotify notify = new FailNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           date =  txtDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void cmbMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            movieID = Convert.ToInt32(cmbMovie.SelectedValue);

        }

        private void cmbHours_SelectedIndexChanged(object sender, EventArgs e)
        {
            hourID = Convert.ToInt32(cmbHours.SelectedValue);
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomID = Convert.ToInt32(cmbRoom.SelectedValue);
        }
    }
}
