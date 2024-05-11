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
    public partial class frmAddCitizen : Form
    {
        public frmAddCitizen()
        {
            InitializeComponent();
        }
        private void frmAddCitizen_Load(object sender, EventArgs e)
        {
            List<MUser> list = new List<MUser>();
            list = ObjectHandler.GetUserDL().getUsersList();
            NameComboBox.Items.Clear();
            foreach (MUser user in list)
                {
                NameComboBox.Items.Add(user.UserName);
            }
        }

        private void lblTempAdress_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblCity_Click(object sender, EventArgs e)
        {

        }

        private void lblCnic_Click(object sender, EventArgs e)
        {

        }

        private void lblFatherName_Click(object sender, EventArgs e)
        {

        }

        private void lblProvince_Click(object sender, EventArgs e)
        {

        }

        private void lblFName_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }



        private void cmdAdd_Click(object sender, EventArgs e)
            {
            if (
                !string.IsNullOrEmpty(txtLastName.Text) &&
                !string.IsNullOrEmpty(cboGender.Text) &&
                !string.IsNullOrEmpty(txtCity.Text) &&
                !string.IsNullOrEmpty(txtCnic.Text) &&
                !string.IsNullOrEmpty(txtFatherName.Text) &&
                !string.IsNullOrEmpty(cboProvince.Text) &&
                !string.IsNullOrEmpty(txtTempAdress.Text) &&
                !string.IsNullOrEmpty(txtPermAdress.Text) &&
                !string.IsNullOrEmpty(cboVaccine.Text) &&
                !string.IsNullOrEmpty(cboDose.Text) &&
                !string.IsNullOrEmpty(dateTimePicker1.Text) &&
                !string.IsNullOrEmpty(txtIncome.Text) &&
                !string.IsNullOrEmpty(txtTotalWorth.Text))
                {
                // Check if the length of the CNIC is exactly 13 characters
                if (txtCnic.Text.Length != 13)
                    {
                    MessageBox.Show("Please enter a CNIC with exactly 13 characters.");
                    return; // Exit the method if the CNIC length is not valid
                    }

                // Check if the CNIC is unique
                List<citizen> sortedList = ObjectHandler.GetCitizenDL().sortedDatalist();

                if (!CitizenDBCRUD.IsCnicUnique(sortedList, txtCnic.Text))
                    {
                    MessageBox.Show("A citizen with this CNIC already exists.");
                    return; // Exit the method if the CNIC is not unique
                    }

                int year, month, day;
                if (int.TryParse(cboDose.Text, out int dose) &&
                    DateTime.TryParse(dateTimePicker1.Text, out DateTime vaccinationDate) &&
                    int.TryParse(txtIncome.Text, out int income) &&
                    int.TryParse(txtTotalWorth.Text, out int totalWorth))
                    {
                    year = vaccinationDate.Year;
                    month = vaccinationDate.Month;
                    day = vaccinationDate.Day;

                    int presentYear = DateTime.Now.Year;
                    citizen ctz = new citizen(NameComboBox.Text, txtLastName.Text, cboGender.Text, txtCity.Text, txtCnic.Text, txtFatherName.Text, cboProvince.Text, txtTempAdress.Text, txtPermAdress.Text, cboVaccine.Text, dose, day, month, year, income, totalWorth);

                    ctz.Age = presentYear - year;

                    // Validation passed, proceed with storing data
                    ObjectHandler.GetCitizenDL().StoreUser(ctz);
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                    }
                else
                    {
                    MessageBox.Show("Please enter valid numeric values for CNIC, Dose, Monthly Income, and Total Worth.");
                    }
                }
            else
                {
                MessageBox.Show("Make sure all the fields are filled!");
                }
            }



        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser form = new frmAddUser();
            form.Show();
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sortedCitizenWithAgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSortedCitizen form = new frmSortedCitizen();
            this.Hide();
            form.Show();
        }

        private void citizenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSearchCitizen form = new frmSearchCitizen();
            form.Show();
            this.Hide();
        }

        private void graphicalStatisticsOfCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void citizenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDelete form = new frmDelete();
            form.Show();
            this.Hide();
        }

        private void userLoginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDeleteAccount form = new frmDeleteAccount();
            form.Show();
            this.Hide();
        }

        private void viewComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmViewComplaint form = new frmViewComplaint();
            form.Show();
            this.Hide();

        }

        private void replyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void healthCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSehatApp form = new frmSehatApp();
            form.Show();
            this.Hide();
        }

        private void citizenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTokenNo form = new frmTokenNo();
            form.Show();
            this.Hide();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCnic form = new frmCnic();
            form.Show();
            this.Hide();
        }

        private void cIVID19CertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCovid form = new frmCovid();
            form.Show();
            this.Hide();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoice form = new frmInvoice();
            form.Show();
            this.Hide();
        }

        private void applicantRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCitizen form = new frmAddCitizen();
            form.Show();
            this.Hide();
        }

        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.Show();
            this.Hide();
        }
    }
}
