using MySql.Data.MySqlClient;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALBoat:IBoatDAL
    {
        public void AddBoat(Boat boat)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `boat`(`Name`, `PricePer2Hours`, `Deposit`, `Capacity`, `Quantity`, `Remark`, `LocationID`) VALUES (@Name, @PricePer2Hours, @Deposit, @Capacity, @Quantity, @Remark, @LocationID)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", boat.Type);
                cmd.Parameters.AddWithValue("@PricePer2Hours", boat.CostPer2Hours);
                cmd.Parameters.AddWithValue("@Deposit", boat.Deposit);
                cmd.Parameters.AddWithValue("@Capacity", boat.Capacity);
                cmd.Parameters.AddWithValue("@Quantity", boat.Quantity);
                cmd.Parameters.AddWithValue("@Remark", boat.Remark);
                cmd.Parameters.AddWithValue("@LocationID", boat.Location.ID);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Boat> ViewAllBoats()
        {
            try
            {
                List<Boat> boats = new List<Boat>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT b.`ID`, b.`Name`, `PricePer2Hours`, `Deposit`, `Capacity`, `Quantity`, `Remark`, b.`LocationID`, l.City FROM `boat` AS b INNER JOIN location AS l ON b.LocationID = l.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string type = dataReader[1].ToString();
                    int quantity = Convert.ToInt32(dataReader[5]);
                    int pricePer2Hours = Convert.ToInt32(dataReader[2]);
                    int deposit = Convert.ToInt32(dataReader[3]);
                    int capacity = Convert.ToInt32(dataReader[4]);
                    string remark = dataReader[6].ToString();
                    int locId = Convert.ToInt32(dataReader[7]);
                    string locCity = dataReader[8].ToString();
                    Location location = new Location(locId,"Unknown",locCity, "Unknown");
                    Boat boat = new Boat(id, type,quantity,pricePer2Hours, remark, deposit, capacity,location);
                    boats.Add(boat);
                }
                conn.Close();
                return boats;
                
            }
            catch (Exception)
            {

                throw;
            }
        
        }
        public void SubtractQuantity(Boat boat)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `boat` SET `Quantity`=`Quantity`-1 WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", boat.ID);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddQuantity(Boat boat)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `boat` SET `Quantity`= `Quantity`+1 WHERE ID =@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", boat.ID);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBoat(Boat boat)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `boat` WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query,conn);
                cmd.Parameters.AddWithValue("@id",boat.ID);
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
