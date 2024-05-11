using LibraryFiles.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;
using LibraryFiles.Utilities;


namespace LibraryFiles.DL
{
    public class ComplaintDBCRUD : IComplaintCRUD
    {
        private static List<Complaint> complaintList = new List<Complaint>();
        string conString = FilePath.GetConnectionString();
        //public static List<Complaint> ComplaintList
        //{
        //    get => complaintList;
        //    set => complaintList = value;
        //}
        public static void addIntoList(Complaint c)
        {
            complaintList.Add(c);
        }
        public void StoreComplaint(Complaint c)
        {
            // store complaint in database
            using (SqlConnection connection = new SqlConnection(conString))
            {
                string query = "INSERT INTO Complaint (username,email,complaint) VALUES (@name, @email,@complaint)";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                     command.Parameters.Clear();
                    command.Parameters.AddWithValue("@name", c.Name);
                    command.Parameters.AddWithValue("@email", c.Email);
                    command.Parameters.AddWithValue("@complaint", c.Complaints);
                    command.ExecuteNonQuery();
            }

        }
        public List<Complaint> Load()
        {
            List<Complaint> complaintsList = new List<Complaint>();

            using (SqlConnection connection = new SqlConnection(FilePath.GetConnectionString()))
            {
                string query = "SELECT username, email, complaint FROM Complaint";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string name = reader["username"].ToString();
                    string email = reader["email"].ToString();
                    string complaint = reader["complaint"].ToString();

                    Complaint c = new Complaint (email, name,  complaint);
                    complaintsList.Add(c);
                }

                reader.Close();
            }

            return complaintsList;
        }

        public Complaint getSpecified(MUser user)
        {
            foreach (var cmp in complaintList)
            {
                if (cmp.Name == user.UserName)
                {
                    return cmp;
                }
            }
            return null;
        }

        public int GetComplaintID(string username)
        {
            SqlConnection coneection = new SqlConnection(conString);
            coneection.Open();
            SqlCommand command = new SqlCommand("SELECT ID FROM Complaint WHERE username = @u", coneection);
            command.Parameters.AddWithValue("@u", username);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            else
            {
                return -1;
            }
        }

        public void UpdateReply(string reply,int id)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            SqlCommand command = new SqlCommand("UPDATE Complaint SET reply = @reply WHERE ID = @id", connection);
            command.Parameters.AddWithValue("@reply", reply);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
