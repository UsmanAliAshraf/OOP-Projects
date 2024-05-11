using LibraryFiles.BL;
using LibraryFiles.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles.DL
{
    public class MUserDBCRUD : IUserDL
    {
        static string s = FilePath.GetConnectionString();
        public static List<MUser> usersList = new List<MUser>();
        public  void addUserIntoList(MUser user)
            {
            usersList.Add(user);
            }
        public List<MUser> getUsersList()
            {
            GetUsers();
            return usersList;
            }
        public static void GetUsers()
        {
            usersList.Clear();
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            string query = "Select username,password,role from credentials";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string Username = reader.GetString(0);
                string Password = reader.GetString(1);
                string role = reader.GetString(2);
                MUser user = new MUser(Username, Password, role);
                usersList.Add(user);
                }
        }
        public static List<MUser> UsersList
        {
            get => usersList;
        }
        public bool ReadUsers() {  return true; }
        public void StoreUser(MUser user) 
        {
            usersList.Add(user);
            SqlConnection connection = new SqlConnection(s); 
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO credentials (username, password, role) VALUES (@username, @password, @role)", connection);
            command.Parameters.AddWithValue("@username", user.UserName);
            command.Parameters.AddWithValue("@password", user.UserPassword);
            command.Parameters.AddWithValue("@role", user.UserRole);
            //query  
            command.ExecuteNonQuery();
            connection.Close();
           
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
    }
}