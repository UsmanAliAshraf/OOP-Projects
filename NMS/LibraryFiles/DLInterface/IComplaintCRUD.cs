using LibraryFiles.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles
{
    public interface IComplaintCRUD
    {
        void StoreComplaint(Complaint c);
         List<Complaint> Load();
         Complaint getSpecified(MUser user);
        int GetComplaintID(string username);
        void UpdateReply(string reply,int id);
    }
}
