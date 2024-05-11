using LibraryFiles.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles
{
    public class ObjectHandler
    {


        //////////////////////////////////////////////////////////// FOR LOGIN/SIGNUP //////////////////////////////////////////////////////////////////////////
                
        //private static IUserDL UserDL = new MUserDBCRUD();
        private static IUserDL UserDL = new MUserFHCRUD();
        public static IUserDL GetUserDL()
        {
            return UserDL;
        }


        //////////////////////////////////////////////////////////// FOR Complaint //////////////////////////////////////////////////////////////////////////
        
        private static IComplaintCRUD ComplaintDL = new ComplaintDBCRUD();
        //private static IComplaintCRUD ComplaintDL = new ComplaintFHCRUD();

        public static IComplaintCRUD GetComplaintDL() 
        { 
            return ComplaintDL;
        }

        //////////////////////////////////////////////////////////// FOR UserFunctions //////////////////////////////////////////////////////////////////////////

         //private static ICitizenCRUD CitizenDL = new CitizenDBCRUD();
         private static ICitizenCRUD CitizenDL = new citizenFHCRUD();
        public static ICitizenCRUD GetCitizenDL()
        {
            return CitizenDL;
        }
    }
}