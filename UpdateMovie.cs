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
    public partial class UpdateMovie : Form
    {
        MovieBUS mb = new MovieBUS();
        ManageMovie parent;
        Movie oldMovie = new Movie();

        public UpdateMovie()
        {
            InitializeComponent();       
        }

        public UpdateMovie(ManageMovie parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            //Get all data of movie
            int movieID = Convert.ToInt32(txtID.Text);
            string title = txtTitle.Text.Trim();
            bool state = true;
            if(txtState.Text == "Finished")
            {
                state = false;
            }
            int genreID = Convert.ToInt32(cmbGenres.SelectedValue);
            string description = txtDescription.Text.Trim();
            Movie movie = new Movie(movieID, title, state, genreID, description);

            //Check empty text field and duplicate movie
            if (CheckEmptyField())
            {
                DisplayFailNotify("Please fill all blank");
            }else if (mb.IsDuplicateMovie(movie))
            {
                DisplayFailNotify("This movie existed\nTry again!");
            }
            else
            {              
                mb.UpdateMovie(movie, movieID);
                parent.LoadData();
                DisplaySuccessNotify("Update movie successfully!");
                this.Close();
            }                
        }

        private void UpdateMovie_Load(object sender, EventArgs e)
        {
            try
            {
                //Get all data of movie from ManageMovie form
                int rowindex = parent.dgvMovies.CurrentCell.RowIndex;
                string id = parent.dgvMovies.Rows[rowindex].Cells[0].Value.ToString();
                string title = parent.dgvMovies.Rows[rowindex].Cells[1].Value.ToString().Trim();
                string state = parent.dgvMovies.Rows[rowindex].Cells[2].Value.ToString();
                string genreID = parent.dgvMovies.Rows[rowindex].Cells[3].Value.ToString();
                string description = parent.dgvMovies.Rows[rowindex].Cells[4].Value.ToString().Trim();
                //Dislay data at Update form
                txtID.Text = id;
                txtTitle.Text = title;
                txtDescription.Text = description;
                bool stt = true;
                if (state.Equals("True"))
                {
                    txtState.Text = "On showing";
                }
                else
                {
                    txtState.Text = "Finished";
                    stt = false;
                }
                cmbGenres.DataSource = mb.GetAllGenres();
                cmbGenres.DisplayMember = "genreName";
                cmbGenres.ValueMember = "genreID";
                cmbGenres.SelectedValue = genreID;
                oldMovie = new Movie(Convert.ToInt32(id), title, stt, Convert.ToInt32(genreID), description);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisplayFailNotify(string str)
        {
            FailNotify notify = new FailNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        public void DisplaySuccessNotify(string str)
        {
            SuccessNotify notify = new SuccessNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        public bool CheckEmptyField()
        {
            if(string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                txtID.Text = "";
                return true;
            }else if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                txtDescription.Text = "";
                return true;
            }
            return false;
        }

    }
}
