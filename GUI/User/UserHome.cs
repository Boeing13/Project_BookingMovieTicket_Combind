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
    public partial class UserHome : Form
    {
        public Entity.User user=null;
        public UserHome()
        {
            InitializeComponent();
        }


        public void loadData()
        {
           
            String date = dtpDate.Value.ToString("yyyy-MM-dd");
            DataTable dt = BUS.H_MovieBus.movieBUS.selectBydate(date);
            lsMovie.DataSource = dt;
            lsMovie.DisplayMember = "title";
            lsMovie.ValueMember = "movieID";
        }
        private void UserHome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookingTicketDataSet.Movie' table. You can move, or remove it, as needed.
            dtpDate.MinDate = Convert.ToDateTime("2018/10/21");
            dtpDate.MaxDate = dtpDate.MinDate.AddDays(3);
            loadData();
        }

        private void lvMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lsMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (lsMovie.SelectedValue ==null)
            {
                MessageBox.Show("Please select a movie first");
                return;
            }
            UserDetailTicket userDetailTicket = new UserDetailTicket(this);
            userDetailTicket.Show();
        }

        public int getSelectedMovie()
        {
            return (int)lsMovie.SelectedValue; 
        }

        public string getSelectedDate()
        {
            
            return dtpDate.Value.ToString("yyyy-MM-dd"); 
            
        }

        public string getMovieName()
        {
            return lsMovie.GetItemText(lsMovie.SelectedItem);
        }

        public void setBtnHistoryEnable(Boolean temp)
        {
            btnHistory.Visible = temp;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
               DialogResult result= MessageBox.Show("Do you want to log out", "Message", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    user = null;
                    setBtnHistoryEnable(false);
                    MessageBox.Show("Log out sucessful");
                }
               
            }
            else
            {
                LoginUser loginUser = new LoginUser(this);
                loginUser.Show();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            History history = new History(this);
            history.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
