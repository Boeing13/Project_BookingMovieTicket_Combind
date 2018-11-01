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
    public partial class AddMovie : Form
    {
        MovieBUS mb = new MovieBUS();
        ManageMovie parent;

        public AddMovie(ManageMovie parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveInsert_Click(object sender, EventArgs e)
        {
            //Get all data of movie
            string title = txtTitle.Text.Trim();
            bool state = true;
            if (cmbState.SelectedIndex == 1)
            {
                state = false;
            }
            int genreID = Convert.ToInt32(cmbGenres.SelectedValue);
            string description = txtDescription.Text.Trim();
            if (CheckEmptyField())
            {
                DisplayFailNotify("Please fill all blank");

            } else if(mb.CheckDuplicate(title, state, genreID, description))
            {
                DisplayFailNotify("This movie existed! Try again");
            }
            else
            {
                mb.InsertNewMovie(title, state, genreID, description);
                DisplaySuccessNotify("Insert new movie successfully!");
                parent.LoadData();
                Clear();
            }
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            cmbGenres.DataSource = mb.GetAllGenres();
            cmbGenres.DisplayMember = "genreName";
            cmbGenres.ValueMember = "genreID";
            cmbGenres.SelectedIndex = 0;
            cmbState.SelectedIndex = 0;
        }

        //Display Fail Notify
        public void DisplayFailNotify(string str)
        {
            FailNotify notify = new FailNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        //Display Success notify
        public void DisplaySuccessNotify(string str)
        {
            SuccessNotify notify = new SuccessNotify();
            notify.lblMessage.Text = str;
            notify.ShowDialog();
        }

        //Check empty text field
        public bool CheckEmptyField()
        {
            if (string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                txtTitle.Text = "";
                return true;
            }else if (string.IsNullOrEmpty(txtDescription.Text.Trim()))
            {
                txtDescription.Text = "";
                return true;
            }
            return false;
        }

        //Clear all text fields 
        public void Clear()
        {
            txtTitle.Text = "";
            txtDescription.Text = "";
            cmbState.SelectedIndex = 0;
            cmbGenres.SelectedIndex = 0;
        }
    }
}
