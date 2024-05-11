using LibraryFiles.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles
{
    public interface IUserDL
    {
        MUser CheckValidation(string userName, string password);
        bool ReadUsers();
        void StoreUser(MUser user);
        List<MUser> getUsersList();
    }
}
