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
    public partial class DeleteMovie : Form
    {
        ManageMovie parent;
        MovieBUS mb = new MovieBUS();
        private int movieID;

        public DeleteMovie(ManageMovie parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Movie movie = mb.GetMovieByID(movieID);
            movie.State = false;
            mb.UpdateMovie(movie, movieID);
            DisplaySuccessNotify("Delete movie successfully!");
            parent.LoadData();
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteMoviee_Load(object sender, EventArgs e)
        {
            //Get all data of movie from ManageMovie form
            int rowindex = parent.dgvMovies.CurrentCell.RowIndex;
            string id = parent.dgvMovies.Rows[rowindex].Cells[0].Value.ToString();
            movieID = Convert.ToInt32(id);
            string title = parent.dgvMovies.Rows[rowindex].Cells[1].Value.ToString();
            string state = parent.dgvMovies.Rows[rowindex].Cells[2].Value.ToString();
            string genreID = parent.dgvMovies.Rows[rowindex].Cells[3].Value.ToString();

            //Dislay data at Delete form
            lblMovieID.Text = id;
            lblName.Text = title;
            if (state.Equals("True"))
            {
                lblState.Text = "On showing";
            }
            else
            {
                lblState.Text = "Finished";
            }
            lblGenre.Text = mb.GetGenreName(Convert.ToInt32(genreID));
        }

        public void DisplaySuccessNotify(string str)
        {
            SuccessNotify notify = new SuccessNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        public void DisplayFailNotify(string str)
        {
            FailNotify notify = new FailNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }
    }
}
