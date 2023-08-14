using MySql.Data.MySqlClient;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALPeople:IPeople
    {
        public void AddPeople(People people)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `people`(`Name`, `Username`, `Password`, `TypeUserID`, `Address`, `City`, `Email`, `Phone`, `LocationID`) VALUES (@Name,@Username,@Password,@TypeUserID,@Address,@City,@Email,@Phone,@LocationID)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                if (people is Worker)
                {
                   
                cmd.Parameters.AddWithValue("@Name", people.Name);
                cmd.Parameters.AddWithValue("@Username", people.Username);
                cmd.Parameters.AddWithValue("@Password", people.Password);
                cmd.Parameters.AddWithValue("@TypeUserID", 2);
                cmd.Parameters.AddWithValue("@Address", people.Address);
                cmd.Parameters.AddWithValue("@City", people.City);
                cmd.Parameters.AddWithValue("@Email", people.Email);
                cmd.Parameters.AddWithValue("@LocationID", ((Worker)people).Location.ID);
                cmd.Parameters.AddWithValue("@Phone", 0);
                }
                else if (people is Customer)
                {
                   
                    cmd.Parameters.AddWithValue("@Name", people.Name);
                    cmd.Parameters.AddWithValue("@Username", people.Username);
                    cmd.Parameters.AddWithValue("@Password", people.Password);
                    cmd.Parameters.AddWithValue("@TypeUserID", 1);
                    cmd.Parameters.AddWithValue("@Address", people.Address);
                    cmd.Parameters.AddWithValue("@City", people.City);
                    cmd.Parameters.AddWithValue("@Email", people.Email);
                    cmd.Parameters.AddWithValue("@LocationID", null);
                    cmd.Parameters.AddWithValue("@Phone", ((Customer)people).PhoneNumber);
                }
               

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        
        
        
        }

        public int CheckUser(string user, string pass)
        {
            MySqlConnection conn = new MySqlConnection(Data.conn);
            string sql = "SELECT ID FROM people WHERE Username = @username AND Password = @password";
            try
            {
                int id;
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.Add("@username", MySqlDbType.String).Value = user;
                cmd.Parameters.Add("@password", MySqlDbType.String).Value = pass;

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = reader.GetInt32("ID");
                    return id;
                }

                return -1;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }


        public People GetUserByID(int id)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT * FROM `people` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", id);
                MySqlDataReader dataReader = cmd.ExecuteReader();

               
                while (dataReader.Read())
                {
                    int pid = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    string username = dataReader[2].ToString();
                    string password = dataReader[3].ToString();
                    int typeid = Convert.ToInt32(dataReader[4]);
                    string address = dataReader[5].ToString();
                    string city = dataReader[6].ToString();
                    string email = dataReader[7].ToString();
                    if (typeid == 2)
                    {
                        int locID = Convert.ToInt32(dataReader[9]);
                        Location location = new Location(locID, "Unknown", "Unknown", "Unknown");
                        Worker worker = new Worker(pid, name, username, password, address, city, email, location);
                        return worker;
                    }
                    else if (typeid == 1)
                    {
                        int phone = Convert.ToInt32(dataReader[8]);
                        Customer customer = new Customer(id, name, username, password, address, city, email, phone);
                        return customer;
                    }
                    
                }
                conn.Close();
                return null;

            }
            catch (Exception)
            {

                throw;
            }


        }

        public void DeleteWorker(Worker worker)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `people` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", worker.ID);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<People> ViewAllPeople()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT p.`ID`, `Name`, `Username`, `Password`, p.`TypeUserID`, `Address`, `City`, `Email`, `Phone`, `LocationID`,t.TypeUser FROM `people` AS p INNER JOIN typeuser AS t ON p.TypeUserID = t.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<People> people = new List<People>();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    string username = dataReader[2].ToString();
                    string password = dataReader[3].ToString();
                    int typeid = Convert.ToInt32(dataReader[4]);
                    string address = dataReader[5].ToString();
                    string city = dataReader[6].ToString();
                    string email = dataReader[7].ToString();
                    
                    
                    if (typeid == 2)
                    {
                        int locID = Convert.ToInt32(dataReader[9]);
                        Location location = new Location(locID, "Unknown", "Unknown", "Unknown");
                        Worker worker = new Worker(id, name, username, password, address, city, email,location);
                        people.Add(worker);
                    }
                    else if (typeid == 1)
                    {
                        int phone = Convert.ToInt32(dataReader[8]);
                        Customer customer = new Customer(id, name, username, password, address, city, email, phone);
                        people.Add(customer);
                    }
                }
                    conn.Close();
                    return people;

            }
            catch (Exception)
            {

                throw;
            }
        
        }



    }
}
