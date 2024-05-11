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
    public partial class frmInvoice : Admin
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            int bill = 0;
            try
                {
                citizen person = CitizenDBCRUD.citizenFromTokenNumber(int.Parse(txtToken.Text));
                if (person != null)
                    {
                    if (chkCnic.Checked)
                        {
                        if (rdUrgent.Checked)
                            {
                            bill = 2500;
                            lblAppFront.Text = "Urgent";
                            lblName.Text = "Total Invoice:";
                            lblApp.Text = "Application Status:";
                            lblID.Text = "CNIC No.";
                            lblIDNo.Text = person.Cnic;
                            lblNameFront.Text = $"{bill}";
                            }
                        else if (rdRegular.Checked)
                            {
                            bill = 1500;
                            lblAppFront.Text = "Regular";
                            lblName.Text = "Total Invoice:";
                            lblApp.Text = "Application Status:";
                            lblID.Text = "CNIC No.";
                            lblIDNo.Text = person.Cnic;
                            lblNameFront.Text = $"{bill}";
                            }
                        else
                            {
                            MessageBox.Show("Select Urgent or Regular");
                            }
                        }
                    else
                        {
                        MessageBox.Show("You Must Check CNIC Box");
                        }
                    }
                else
                    {
                    MessageBox.Show("No user found with this token number");
                    }
                }
            catch (FormatException)
                {
                MessageBox.Show("Invalid token number format");
                }
            catch (Exception ex)
                {
                MessageBox.Show($"An error occurred: {ex.Message}");
                }




            }
        }
}
