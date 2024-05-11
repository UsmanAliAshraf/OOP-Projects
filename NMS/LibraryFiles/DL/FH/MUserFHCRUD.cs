using LibraryFiles.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles.DL
{
    public class MUserFHCRUD : IUserDL
    {
        static string path = "credentials.txt";
        public static List<MUser> usersList = new List<MUser>();

        public void addUserIntoList(MUser user)
        {
            usersList.Add(user);
        }
        public List<MUser> getUsersList()
        {
            return usersList;
        }

        public static List<MUser> UsersList
        {
            get => usersList;
        }

        public bool ReadUsers()
        {
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string userName = parseData(record, 1);
                    string userPassword = parseData(record, 2);
                    string userRole = parseData(record, 3);
                    MUser user = new MUser(userName, userPassword, userRole);
                    addUserIntoList(user);
                }
                fileVariable.Close();
                return true;
            }

            return false;


        }
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        public void StoreUser(MUser user)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(user.UserName + "," + user.UserPassword + "," + user.UserRole);
            file.Flush();
            file.Close();
            usersList.Add(user);
        }
        public MUser CheckValidation(string userName, string password)
        {
            foreach (var user in usersList)
            {
                if (user.UserName == userName && user.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }
        static public bool checkUserDuplication(string userName, string password)
        {
            foreach (var user in usersList)
            {
                if ((user.UserName == userName && user.UserPassword == password) || (userName == "ADMIN" && password == "ADMIN"))
                {
                    return false;
                }
            }
            return true;
        }

        static public void deleteUserFromList(MUser user)
        {
            for (int x = 0; x < usersList.Count; x++)
            {
                if (usersList[x].UserName == user.UserName && usersList[x].UserPassword == user.UserPassword && usersList[x].UserRole == user.UserRole)
                {
                    usersList.RemoveAt(x);
                }
            }
        }
    }
}
