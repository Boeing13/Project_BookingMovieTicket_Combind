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
    public partial class UserOrder : Form
    {
        UserDetailTicket userDetail;
        public UserOrder(UserDetailTicket userDetailTicket)
        {
            InitializeComponent();
            this.userDetail = userDetailTicket;
        }

        private void UserOrder_Load(object sender, EventArgs e)
        {
            lbUName.Text = "UserName: "+ userDetail.userHome.user.FullName;
            lbAddress.Text ="Address: "+ userDetail.userHome.user.Address;
            lbTel.Text = "Tel: "+ userDetail.userHome.user.Tel;
            lbMName.Text ="Movie Name:" + userDetail.userHome.getMovieName();
            lbHour.Text = "Hour: " + userDetail.getHour();
            lbType.Text = "Type: " + userDetail.getType();
            lbTickets.Text = "Number of tickets: " + userDetail.getNbTickets();
            lbRoom.Text = "Room: " + BUS.H_MovieBus.movieBUS.getRoomName(userDetail.rid); ;
            double price = BUS.H_MovieBus.movieBUS.getPrice(userDetail.getTypeValue());
            MessageBox.Show(price.ToString());
            int tickets = userDetail.getNbTickets();
            double result = price * tickets;
            lbTotal.Text = "Total: " + result;
        }

        private void lbMName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
          int totalTickets=  BUS.H_MovieBus.movieBUS.getNumberofTickets(userDetail.rid, userDetail.getHourValue(), DateTime.Parse(userDetail.userHome.getSelectedDate()));
            int seat=totalTickets- userDetail.getNbTickets();
           int result= BUS.H_MovieBus.movieBUS.bookTickets(userDetail.rid, userDetail.userHome.getSelectedMovie(), DateTime.Parse(userDetail.userHome.getSelectedDate()), seat);

            if (result > 0)
            {
                int movieID = userDetail.userHome.getSelectedMovie();
                int typeID = userDetail.getTypeValue();
                int hourID = userDetail.getHourValue();
                DateTime dateTime=   DateTime.Parse(userDetail.userHome.getSelectedDate());
                int ticketOrder= userDetail.getNbTickets();
                int userID = userDetail.userHome.user.UserID;
                result= BUS.H_MovieBus.movieBUS.inserInBookingHistory(userID, movieID, typeID, hourID, dateTime, ticketOrder);
                if (result > 0)
                {
                    MessageBox.Show("Book successful");
                }
                else
                {
                    MessageBox.Show("Book not successful");
                }
            }
            else
            {
                MessageBox.Show("Book not successful");
            }
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
