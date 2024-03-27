using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    internal class AddingStudentsData
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Documents\universityDB.mdf;Integrated Security=True;Connect Timeout=30");
        public int ID { get; set; }
        public string StudName { get; set; }
        public string StudSecName { get; set; }
        public string StudPatronymic { get; set; }
        public string StudGender { get; set; }
        public string StudAddress { get; set; }
        public string StudUsername { get; set; }
        public string StudPassword { get; set; }
        public string StudPhoneNum { get; set; }
        public string DateInsert { get; set; }

        public List<AddingStudentsData> GetStudentData()
        {
            List<AddingStudentsData> listData = new List<AddingStudentsData>();
            if (conn.State != ConnectionState.Open)
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT * FROM teachers WHERE date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            AddingStudentsData addSD = new AddingStudentsData();
                            addSD.ID = (int)reader["id"];
                            addSD.StudName = reader["firstName"].ToString();
                            addSD.StudSecName = reader["secName"].ToString();
                            addSD.StudPatronymic = reader["patronymic"].ToString();
                            addSD.StudGender = reader["gender"].ToString();
                            addSD.StudAddress = reader["address"].ToString();
                            addSD.StudUsername = reader["username"].ToString();
                            addSD.StudPassword = reader["passw"].ToString();
                            addSD.StudPhoneNum = reader["phoneNum"].ToString();
                            addSD.DateInsert = reader["dateInsert"].ToString();

                            listData.Add(addSD);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting Database: " + ex);
                }
                finally
                {
                    conn.Close();
                }
            }
            return listData;

        }
    }
}
