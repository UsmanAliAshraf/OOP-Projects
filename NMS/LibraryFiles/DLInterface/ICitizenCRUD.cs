using LibraryFiles.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles
{
    public interface ICitizenCRUD
    {
         void StoreUser(citizen citizen);
         void load();
         citizen SearchCitizen1(string cnic);
        void deleteUserFromList(citizen user);
        List<citizen> sortedDatalist();
        void addCitizenIntoList(citizen c);

    }
}
