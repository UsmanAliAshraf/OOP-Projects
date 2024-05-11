using LibraryFiles.BL;
using LibraryFiles.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFiles.DL
    {
    public class ComplaintFHCRUD 
        {
        private static List<Complaint> complaintList = new List<Complaint>();
        static string path = FilePath.complaintpath;
        public static List<Complaint> ComplaintList
            {
            get => complaintList;
            set => complaintList = value;

            }
        public static void addIntoList(Complaint c)
            {
            complaintList.Add(c);          
            }
        public static void StoreComplaint(Complaint c)
            {
            StreamWriter file = new StreamWriter(path, true);
            file.Write(c.Email + "|" + c.Name + "|", c.Complaints);
            file.Flush();
            file.Close();
            }
        public static void load(string path)
            {
            //***********************laoding recorda from file***************************************************


            string line;

            if (File.Exists(path))
                {
                StreamReader file = new StreamReader(path);

                while (((line = file.ReadLine())) != null)
                    {
                    string[] record = line.Split(',');
                    Complaint Add = new Complaint(record[0], record[1], record[2]);
                    addIntoList(Add);

                    // uploaading temporary arr1ay data into orignal array
                    }
                file.Close();
                }

            }

        public int GetComplaintID(string username)
        {
            return 0;
        }

        public static Complaint getSpecified(MUser user)
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

        public void UpdateReply(string reply, int id)
        {

        }
    }
    }
