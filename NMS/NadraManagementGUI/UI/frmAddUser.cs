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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSignUp_Click(object sender, EventArgs e)
        {
            MUser user = new MUser(txtUserName.Text, txtPassword.Text, cboUserRole.Text);
            ObjectHandler.GetUserDL().StoreUser(user);
            MessageBox.Show("SuccessFully Done!");
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }
        }
}
