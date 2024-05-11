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
    public partial class frmViewComplaint : frmApplicant
    {
        public frmViewComplaint()
        {
            InitializeComponent();
        }

        private void frmViewComplaint_Load(object sender, EventArgs e)
        {
            Complaint c = ComplaintFHCRUD.getSpecified(Communication.User);
            if (c != null)
            {
                lblMail.Text = c.Reply;
            }
        }

        private void lblMail_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
