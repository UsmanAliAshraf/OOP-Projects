using LibraryFiles.BL;
using LibraryFiles.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles.DL
{
    public class CitizenDBCRUD: ICitizenCRUD
    {
        private static List<citizen> dataListDB = new List<citizen>();
        private static List<citizen> sortedDataList = new List<citizen>();
        public static List<citizen> SortedDataList => sortedDataList;
        public  List<citizen> sortedDatalist()
            {
            sortedDataList = dataListDB.OrderByDescending((citizen o) => o.Age).ToList();
            return sortedDataList;
            }
        public  void addCitizenIntoList(citizen c)
            {
            dataListDB.Add(c);
            }

        public static List<citizen> GetDataList()
        {             
            return dataListDB;
        }
        public void StoreUser(citizen citizen)
        {
            string connectionString =FilePath.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO CitizenData (Name, LastName, Gender, City, Cnic, FatherName, Province, TemporaryAdress, PermanentAdress, VaccineName, VaccineDose, Date,Month,Year, Income,TotalWorth, Age, TokenNumber) VALUES (@Name, @LastName, @Gender, @City, @Cnic, @FatherName, @Province, @TemporaryAdress, @PermanentAdress, @VaccineName, @VaccineDose, @Date, @Month, @Year, @Income, @TotalWorth, @Age, @TokenNumber)";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();


                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@Name", citizen.Name);
                    command.Parameters.AddWithValue("@LastName", citizen.LastName);
                    command.Parameters.AddWithValue("@Gender", citizen.Gender);
                    command.Parameters.AddWithValue("@City", citizen.City);
                    command.Parameters.AddWithValue("@Cnic", citizen.Cnic);
                    command.Parameters.AddWithValue("@FatherName", citizen.FatherName);
                    command.Parameters.AddWithValue("@Province", citizen.Province);
                    command.Parameters.AddWithValue("@TemporaryAdress", citizen.Temp_adress);
                    command.Parameters.AddWithValue("@PermanentAdress", citizen.PermanentAdress);
                    command.Parameters.AddWithValue("@VaccineName", citizen.VaccineName);
                    command.Parameters.AddWithValue("@VaccineDose", citizen.Dose);
                    command.Parameters.AddWithValue("@Date", citizen.Date);
                    command.Parameters.AddWithValue("@Month", citizen.Month);
                    command.Parameters.AddWithValue("@Year", citizen.Year);
                    command.Parameters.AddWithValue("@Income", citizen.Income);
                    command.Parameters.AddWithValue("@TotalWorth", citizen.WorthTotal);
                    command.Parameters.AddWithValue("@Age", citizen.Age);
                    command.Parameters.AddWithValue("@TokenNumber", citizen.TokenNumber);
                    command.ExecuteNonQuery();
                
            }
        }



        public static void UpdateTokenNumber(citizen citizenToUpdate, int newTokenNumber)
            {
            // Update the token number in the database
            string connectionString = FilePath.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                string query = "UPDATE CitizenData SET TokenNumber = @TokenNumber WHERE Cnic = @Cnic";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TokenNumber", newTokenNumber);
                command.Parameters.AddWithValue("@Cnic", citizenToUpdate.Cnic);
                connection.Open();
                command.ExecuteNonQuery();
                }

            foreach (var citizen in dataListDB)
                {
                if (citizen.Cnic == citizenToUpdate.Cnic)
                    {
                    citizen.TokenNumber = newTokenNumber;
                    break; // Assuming each citizen has a unique CNIC, we can break once found
                    }
                }
            }





        public void deleteUserFromList(citizen user)
            {
            string connectionString = FilePath.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                connection.Open();
                string query = "DELETE FROM CitizenData WHERE Cnic = @Cnic";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Cnic", user.Cnic);
                command.ExecuteNonQuery();
                dataListDB.Remove(user);
                }
            }

        public static citizen SearchCitizen(string cnic)
        {
            foreach (var person in dataListDB)
            {
                if (person.Name == cnic)
                {
                    return person;
                }
            }
            return null;
        }
        public citizen SearchCitizen1(string cnic)
            {
            foreach (var person in dataListDB)
                {
                if (person.Cnic == cnic)
                    {
                    return person;
                    }
                }
            return null;
            }

        public void load()
        {
                        string connectionString = FilePath.GetConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                string query = "SELECT * FROM CitizenData";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                    {
                    citizen citizen = new citizen();
                    citizen.Name = reader["Name"].ToString();
                    citizen.LastName = reader["LastName"].ToString();
                    citizen.Gender = reader["Gender"].ToString();
                    citizen.Age = Convert.ToInt32(reader["Age"]);
                    citizen.City = reader["City"].ToString();
                    citizen.Cnic = reader["Cnic"].ToString();
                    citizen.Date = Convert.ToInt32(reader["Date"]);
                    citizen.Month = Convert.ToInt32(reader["Month"]);
                    citizen.Year = Convert.ToInt32(reader["Year"]);
                    citizen.FatherName = reader["FatherName"].ToString();
                    citizen.Income = Convert.ToInt32(reader["Income"]);
                    citizen.PermanentAdress = reader["PermanentAdress"].ToString();
                    citizen.Province = reader["Province"].ToString();
                    citizen.Temp_adress = reader["TemporaryAdress"].ToString();
                    citizen.TokenNumber = Convert.ToInt32(reader["TokenNumber"]);
                    citizen.VaccineName = reader["VaccineName"].ToString();
                    citizen.WorthTotal = Convert.ToInt32(reader["TotalWorth"]);
                    citizen.Dose = Convert.ToInt32(reader["VaccineDose"]);
                    dataListDB.Add(citizen);
                    }
                }
        }

        public static citizen citizenFromTokenNumber(int TokenNumber)
            {
            foreach (var person in dataListDB)
                {
                if (person.TokenNumber == TokenNumber)
                    {
                    return person;
                    }
                }
            return null;
            }
        public static bool IsCnicUnique(List<citizen> citizensList, string cnicToCheck)
            {
            foreach (citizen ctz in citizensList)
                {
                if (ctz.Cnic == cnicToCheck)
                    {
                    // CNIC is not unique, found a matching CNIC in the list
                    return false;
                    }
                }
            // CNIC is unique, not found in the list
            return true;
            }

        }
    }
