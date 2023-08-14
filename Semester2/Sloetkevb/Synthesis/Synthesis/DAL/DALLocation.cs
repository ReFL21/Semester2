using MySql.Data.MySqlClient;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALLocation:ILocation
    {
        public void AddLocation(Location location)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `location`(`Name`, `City`, `Address`) VALUES (@Name, @City, @Address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", location.Name);
                cmd.Parameters.AddWithValue("@City", location.City);
                cmd.Parameters.AddWithValue("@Address", location.Address);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Location> ViewAllLocations()
        {
            try
            {
                List<Location> locations = new List<Location>();

                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT * FROM `location`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    string city = dataReader[2].ToString();
                    string address = dataReader[3].ToString();
                    Location location = new Location(id, name, city, address);
                    locations.Add(location);

                }
                conn.Close();
                return locations;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteLocation(Location location)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `location` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", location.ID);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void EditLocation(int id, string name, string city,string address)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `location` SET `Name`=@Name,`City`=@City,`Address`=@Address WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@City", city);
                cmd.Parameters.AddWithValue("@Address", address);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
