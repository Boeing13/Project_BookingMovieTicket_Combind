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
    public partial class UserDetailTicket : Form
    {
       public User.UserHome userHome;
       public int mid;
       public int rid;
        public UserDetailTicket(User.UserHome userHome)
        {
            InitializeComponent();
            this.userHome = userHome;
        }

        public void loadData()
        {
           string date= userHome.getSelectedDate();
             mid = userHome.getSelectedMovie();
           DataTable dt=  BUS.H_MovieBus.movieBUS.getSelectedByDateAndMID(date, mid);
            cbHour.DataSource = dt;
            cbHour.DisplayMember = "time";
            cbHour.ValueMember = "hourID";

            DataTable dtType = BUS.H_MovieBus.movieBUS.getType();
            cbType.DataSource = dtType;
            cbType.DisplayMember = "name";
            cbType.ValueMember = "typeID";
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserDetailTicket_Load(object sender, EventArgs e)
        {
            loadData();
            lbName.Text = userHome.getMovieName();
            lbTypeMovie.Text = BUS.H_MovieBus.movieBUS.getGenre(mid);
            txtDescription.Text = BUS.H_MovieBus.movieBUS.getDescription(mid);
        }

        public int getseat()
        {
            int hid =(int) cbHour.SelectedValue;
            DateTime dateTime = Convert.ToDateTime(userHome.getSelectedDate());
            int seats = (int)nudSeat.Value;
            int rid=   BUS.H_MovieBus.movieBUS.getRoomID(mid, hid, dateTime, seats);
            return rid;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int seats = (int)nudSeat.Value;
            if (seats <= 0) 
            {
                    MessageBox.Show("Number of seats must be >0");
                    return;
            }

             rid = getseat();
            if (rid > -1)
            {
                if (userHome.user!=null)
                {
                    UserOrder userOrder = new UserOrder(this);
                    userOrder.Show();
                }
                else
                {
                    MessageBox.Show("Please login first");
                    LoginUser loginUser = new LoginUser(userHome);
                    loginUser.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Dont have enough seat in that movie hour");
            }
        }

        public String getHour()
        {
            return cbHour.Text;
        }

        public int getHourValue()
        {
            return Convert.ToInt32(cbHour.SelectedValue);
        }

        public String getType()
        {
            return cbType.Text;
        }

        public int getTypeValue()
        {
            return Convert.ToInt32(cbType.SelectedValue);
        }

        public int getNbTickets()
        {
            return Convert.ToInt32(nudSeat.Value);
        }
    }
}
