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
    public partial class ManageMovie : UserControl
    {
        MovieBUS mb = new MovieBUS();

        public ManageMovie()
        {
            InitializeComponent();
        }

        private void ManageMovie_Load(object sender, EventArgs e)
        {
            try
            {
                cmbState.SelectedIndex = 0;
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedCells.Count > 0)
            {
                UpdateMovie detail = new UpdateMovie(this);
                detail.ShowDialog();
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie add = new AddMovie(this);
            add.ShowDialog();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            DeleteMovie delete = new DeleteMovie(this);
            delete.ShowDialog();                       
        }

        public void LoadData()
        {
            bool state = true;
            if (cmbState.SelectedIndex == 1) state = false;
            DataTable dt = new DataTable();
            dt = mb.GetMoviesByState(state);
            dgvMovies.DataSource = dt;
        }

        private void cmbState_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbState.SelectedIndex == 1)
            {
                btnDeleteMovie.Enabled = false;
                LoadData();
            }
            else
            {
                btnDeleteMovie.Enabled = true;
                LoadData();
            }
        }
    }
}
