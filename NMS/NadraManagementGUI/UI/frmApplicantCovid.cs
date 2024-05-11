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
    public partial class frmApplicantCovid : frmApplicant
    {
        public frmApplicantCovid()
        {
            InitializeComponent();
        }

        private void frmApplicantCovid_Load(object sender, EventArgs e)
        {

        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            citizen person = ObjectHandler.GetCitizenDL().SearchCitizen1(txtToken.Text);

            if (person != null)
            {
                frmCovidCard form = new frmCovidCard(person);
                form.Show();
            }
            else
            {
                MessageBox.Show("Not Registered!");
            }

        }
    }
}
