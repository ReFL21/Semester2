using MySql.Data.MySqlClient;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALItems:IItemsDAL
    {
        public void AddItem(Items item)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `items`(`Name`, `PricePer2Hours`, `Deposit`, `Quantity`, `Remark`, `LocationID`) VALUES (@Name , @PricePer2Hours, @Deposit, @Quantity, @Remark, @LocationID)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", item.Name);
                cmd.Parameters.AddWithValue("@PricePer2Hours", item.CostPer2Hous);
                cmd.Parameters.AddWithValue("@Deposit", item.Deposit);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.Parameters.AddWithValue("@Remark", item.Remark);
                cmd.Parameters.AddWithValue("@LocationID", item.Location.ID);


                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Items> ViewAllItems()
        {
            try
            {
                List<Items> items = new List<Items>();
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT i.`ID`, i.`Name`, `PricePer2Hours`, `Deposit`, `Quantity`, `Remark`, i.`LocationID`, l.City FROM `items` AS i INNER JOIN location AS l ON i.LocationID = l.ID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    string name = dataReader[1].ToString();
                    int priceper2h =Convert.ToInt32(dataReader[2]);
                    int deposit = Convert.ToInt32(dataReader[3]);
                    int quantity = Convert.ToInt32(dataReader[4]);
                    string remark = dataReader[5].ToString();
                    int locID = Convert.ToInt32(dataReader[6]);
                    string locCity = dataReader[7].ToString();
                    Location location = new Location(locID,"unknown",locCity, "unknown");
                    Items item = new Items(id,name, deposit,priceper2h,quantity, remark, location );
                    items.Add(item);
                }
                conn.Close();
                return items;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void SubtractQuantity(Items items)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `items` SET`Quantity`= `Quantity`-1 WHERE ID=@id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", items.ID);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AddQuantity(Items items)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `items` SET `Quantity`=`Quantity`+1 WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", items.ID);
                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteItem(Items items)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "DELETE FROM `items` WHERE ID = @id";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", items.ID);

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
