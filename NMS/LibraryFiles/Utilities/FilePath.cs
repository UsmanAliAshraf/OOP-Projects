using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles.Utilities
    {
    public class FilePath
        {
        public static string credentialPath = "credentials.txt";
        public static string dataPath = "data.txt";
        public static string sahatAppPath = "sahatApp.txt";
        public static string sahatSelectPath = "sahatSelect.txt";
        public static string complaintpath = " complaints.txt";
        public  static string conString = "Data Source=USMAN-PC;Initial Catalog=NMS;Integrated Security=True";
        public static string GetConnectionString() 
            {
            return conString;
            
            }
        }

    }