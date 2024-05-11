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
    public partial class LoginHome : Form
    {
        
        public LoginHome()
        {
            InitializeComponent();

        }

        private void cmdLoginClick_Click(object sender, EventArgs e)
        {
            
            LoginScreen login = new LoginScreen();
            login.Show();
    
            
        }
        private void LoginHome_Load(object sender, EventArgs e)
        {
            citizenFHCRUD.loadFromFileSahatApp(FilePath.sahatAppPath, FilePath.sahatSelectPath);
            ObjectHandler.GetCitizenDL().load();
            ObjectHandler.GetUserDL().ReadUsers();
            ComplaintFHCRUD.load(FilePath.complaintpath);
        }
    }
}
