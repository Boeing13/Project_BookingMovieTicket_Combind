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
                DataTable dt = new DataTable();
                dt = mb.SelectAll();
                dgvMovies.DataSource = dt;
            }
            catch (Exception)
            {

            }
        }

        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            if (dgvMovies.SelectedCells.Count > 0)
            {
                int rowindex = dgvMovies.CurrentCell.RowIndex;
                string id = dgvMovies.Rows[rowindex].Cells[0].Value.ToString();
                string title = dgvMovies.Rows[rowindex].Cells[1].Value.ToString();
                string state = dgvMovies.Rows[rowindex].Cells[2].Value.ToString();
                
                UpdateMovie detail = new UpdateMovie(id, title, state);
                detail.ShowDialog();
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            AddMovie add = new AddMovie();
            add.Show();
        }
    }
}
