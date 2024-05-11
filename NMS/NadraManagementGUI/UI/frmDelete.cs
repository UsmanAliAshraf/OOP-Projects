using LibraryFiles;
using LibraryFiles.BL;
using LibraryFiles.DL;
using LibraryFiles.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NadraManagementGUI
{
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }
        public void dataBind()
        {
            dataGridViewDeleteCitizen.DataSource = ObjectHandler.GetCitizenDL().sortedDatalist();
            dataGridViewDeleteCitizen.Refresh();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            citizen person = (citizen)dataGridViewDeleteCitizen.CurrentRow.DataBoundItem;
            if (dataGridViewDeleteCitizen.Columns["Delete"].Index == e.ColumnIndex)
            {
                ObjectHandler.GetCitizenDL().deleteUserFromList(person);
                MessageBox.Show("Deleted Successfully");
                //ObjectHandler.GetCitizenDL().StoreUser(person);
                dataBind();
            }
        }
        private void frmDelete_Load(object sender, EventArgs e)
        {
            dataGridViewDeleteCitizen.DataSource = ObjectHandler.GetCitizenDL().sortedDatalist();
        }

        private void userLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteAccount form = new frmDeleteAccount();

            form.Show();
            this.Hide();
        }
    }
}