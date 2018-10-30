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
    public partial class UpdateMovie : Form
    {

        public UpdateMovie()
        {
            InitializeComponent();
        }

        public UpdateMovie(string id, string title, string state)
        {
            InitializeComponent();
            txtID.Text = id;
            txtTitle.Text = title;
            if (state.Equals("True"))
            {
                cmbState.SelectedItem = "On showing";
            }
            else
                cmbState.SelectedItem = "Finished";
           
        }

        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
