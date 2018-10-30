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
    public partial class AddSchedule : Form
    {
        ScheduleBUS sbus = new ScheduleBUS();
        ManageSchedule parent;
        public AddSchedule()
        {
            InitializeComponent();
        }

        private void AddSchedule_Load(object sender, EventArgs e)
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

            txtDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            
                  
        }

        public AddSchedule(ManageSchedule parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtDate.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
            
        }

        public void DisplayFailNotify(string str)
        {
            FailNotify notify = new FailNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Schedule schedule = new Schedule()
                {
                    RoomID = Convert.ToInt32(cmbRoom.SelectedValue),
                    HourID = Convert.ToInt32(cmbHours.SelectedValue),
                    MovieID = Convert.ToInt32(cmbMovie.SelectedValue),
                    Date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"),
                    LeftSeat = Convert.ToInt32(txtSeat.Text)
                };
                if(Convert.ToInt32(txtSeat.Text) <= 0)
                {
                    DisplayFailNotify("Left seat must be possitive number");
                   
                    return;
                }

                int state = sbus.InsertNewSchedule(schedule);
                if (state == 1)
                {

                    SuccessNotify notify = new SuccessNotify();
                    notify.lblMessage.Text = "Add new schedule successfully!";
                    notify.ShowDialog();
                }
            }
            catch (FormatException)
            {
                DisplayFailNotify("Left seat must be possitive number");

            }
            catch(Exception)
            {
                DisplayFailNotify("This schedule has already been used");

            }
            parent.LoadData();

        }
    }
}
