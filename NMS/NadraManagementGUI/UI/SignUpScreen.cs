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
    public partial class SignUp : Form
    {
        private string path="credentials";
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void cmdSignUp_Click(object sender, EventArgs e)
            {
            // Check if username, password, and role are not empty
            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(cboUserRole.Text))
                {
                MessageBox.Show("Username, password, and role are required fields.");
                return; // Exit the method if any field is empty
                }

            // Check if the length of username and password is at least 4 characters
            if (txtUserName.Text.Length < 4 || txtPassword.Text.Length < 4)
                {
                MessageBox.Show("Username and password must be at least 4 characters long.");
                return; // Exit the method if any field's length is less than 4
                }

            // Create a new user object
            MUser user = new MUser(txtUserName.Text, txtPassword.Text, cboUserRole.Text);

            // Store the user
            ObjectHandler.GetUserDL().StoreUser(user);

            // Close the form
            this.Close();
            }


        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtUserName_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUserName.Text == "Username")
                txtUserName.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
            {
            if (txtPassword.Text == "Password")
                txtPassword.Clear();
            }

        private void cboUserRole_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        }
}
