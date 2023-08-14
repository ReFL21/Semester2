using MySql.Data.MySqlClient;
using Synthesis.Classes;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.DAL
{
    class DALRent : IRent
    {
        public void AddRent(Rent rent)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `rentaldocument`( `Date`, `StartDate`, `EndDate`, `PeopleID`, `LocationID`, `Note`, `Status`) VALUES (@Date, @StartDate, @EndDate, @PeopleID, @LocationID, @Note, @Status)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                cmd.Parameters.AddWithValue("@StartDate", rent.StartingDate);
                cmd.Parameters.AddWithValue("@EndDate", rent.EndDate);
                cmd.Parameters.AddWithValue("@PeopleID", rent.Person.ID);
                cmd.Parameters.AddWithValue("@LocationID", rent.Location.ID);
                cmd.Parameters.AddWithValue("@Note", rent.Note);
                cmd.Parameters.AddWithValue("@Status", rent.Status.ToString());

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void UpdateRent(int id, DateTime date, DateTime Startdate, DateTime Enddate, Location location)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `rentaldocument` SET `Date`=@Date,`StartDate`=@StartDate,`EndDate`=@EndDate,`LocationID`=@LocationID WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@StartDate", Startdate);
                cmd.Parameters.AddWithValue("@EndDate", Enddate);
                cmd.Parameters.AddWithValue("@LocationID", location.ID);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EndRent(Rent rent, RentalStatus status)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "UPDATE `rentaldocument` SET `Status`=@Status WHERE ID = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", rent.ID);
                cmd.Parameters.AddWithValue("@Status", status.ToString());

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }


        }

        public List<Rent> ViewAllRents()
        {
            List<Rent> rents = new List<Rent>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT * FROM `rentaldocument`";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    DateTime date = Convert.ToDateTime(dataReader[1]);
                    DateTime startdate = Convert.ToDateTime(dataReader[2]);
                    DateTime enddate = Convert.ToDateTime(dataReader[3]);
                    int customerid = Convert.ToInt32(dataReader[4]);
                    Customer customer = new Customer(customerid, "unknow", "HDZ", "HDZ", "qwerwt", "ASDFAS", "fasdfasdf", 1264824682);
                    int locationid = Convert.ToInt32(dataReader[5]);
                    Location location = new Location(locationid, "asdfasdf", "asdfasdf", "asdfasdf");
                    string note = dataReader[6].ToString();
                    if (dataReader[7].ToString() == "Pending")
                    {
                        RentalStatus rentalStatus = (RentalStatus)0;
                        Rent rent = new Rent(id, date, startdate, enddate, customer, note, rentalStatus, location);
                        rents.Add(rent);
                    }
                    else if (dataReader[7].ToString() == "Started")
                    {
                        RentalStatus rentalStatus = (RentalStatus)1;
                        Rent rent = new Rent(id, date, startdate, enddate, customer, note, rentalStatus, location);
                        rents.Add(rent);
                    }
                    else if (dataReader[7].ToString() == "Ended")
                    {
                        RentalStatus rentalStatus = (RentalStatus)2;
                        Rent rent = new Rent(id, date, startdate, enddate, customer, note, rentalStatus, location);
                        rents.Add(rent);
                    }


                }
                conn.Close();
                return rents;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void AddBoatsToRent(RentedProduct rentedProducts)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `rentedproduct`(`RentID`, `BoatID`, `ItemID`, `Quantity`, `TotalPrice`) VALUES (@RentID,@BoatID,@ItemID,@Quantity,@TotalPrice)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RentID", rentedProducts.Rent.ID);
                cmd.Parameters.AddWithValue("@BoatID", rentedProducts.Boat.ID);
                cmd.Parameters.AddWithValue("@ItemID", 0);
                cmd.Parameters.AddWithValue("@Quantity", rentedProducts.Quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", rentedProducts.Boat.Deposit);

                conn.Open();
                cmd.ExecuteReader();
                conn.Close();

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void AddItemsTORent(RentedProduct rentedProducts)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "INSERT INTO `rentedproduct`(`RentID`, `BoatID`, `ItemID`, `Quantity`, `TotalPrice`) VALUES (@RentID,@BoatID,@ItemID,@Quantity,@TotalPrice)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RentID", rentedProducts.Rent.ID);
                cmd.Parameters.AddWithValue("@BoatID", 0);
                cmd.Parameters.AddWithValue("@ItemID", rentedProducts.Items.ID);
                cmd.Parameters.AddWithValue("@Quantity", rentedProducts.Quantity);
                cmd.Parameters.AddWithValue("@TotalPrice", rentedProducts.Items.Deposit);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<RentedProduct> ViewRentedBoats(int Rentid)
        {
            List<RentedProduct> renteds = new List<RentedProduct>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT `ID`, `RentID`, `BoatID`, `Quantity`, `TotalPrice` FROM `rentedproduct` WHERE RentID = @rentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rentId", Rentid);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    int rentid = Convert.ToInt32(dataReader[1]);
                    Location location = new Location("asdasd", "dasdads", "dasdad"); 
                    Customer customer = new Customer(651,"unknow", "HDZ", "HDZ", "qwerwt", "ASDFAS", "fasdfasdf", 1264824682);
                    Rent rent = new Rent(rentid,DateTime.Now, DateTime.Now, DateTime.Now,customer,"adad",(RentalStatus)1, location);
                    //  int boatid = Convert.ToInt32(dataReader[2]);
                    //  int itemid = Convert.ToInt32(dataReader[3]);
                        int boatid = Convert.ToInt32(dataReader[2]);
                        Boat boat = new Boat(boatid, "asd", 1, 1, "asdasd", 1, 1, location);
                        int quantity = Convert.ToInt32(dataReader[3]);
                        int totalPrice = Convert.ToInt32(dataReader[4]);
                        RentedProduct rentedProducts = new RentedProduct(id, rent,boat,quantity, totalPrice);
                        renteds.Add(rentedProducts);
                    
                        
                    
                    
                }
                conn.Close();
                return renteds;

            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<RentedProduct> ViewRentedItems(int Rentid)
        {
            List<RentedProduct> renteds = new List<RentedProduct>();
            try
            {
                MySqlConnection conn = new MySqlConnection(Data.conn);
                string query = "SELECT `ID`, `RentID`, `ItemID`, `Quantity`, `TotalPrice` FROM `rentedproduct` WHERE RentID = @rentId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@rentId", Rentid);
                conn.Open();
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = Convert.ToInt32(dataReader[0]);
                    int rentid = Convert.ToInt32(dataReader[1]);
                    Location location = new Location("asdasd", "dasdads", "dasdad");
                    Customer customer = new Customer(651, "unknow", "HDZ", "HDZ", "qwerwt", "ASDFAS", "fasdfasdf", 1264824682);
                    Rent rent = new Rent(rentid, DateTime.Now, DateTime.Now, DateTime.Now, customer, "adad", (RentalStatus)1, location);
                    if (dataReader[2] == null)
                    { 
                    int itemid = Convert.ToInt32(dataReader[2]);
                    Items items = new Items(itemid, "sdaasd", 1, 1, 1, "asdad", location);
                    int quantity = Convert.ToInt32(dataReader[3]);
                    int totalPrice = Convert.ToInt32(dataReader[4]);
                    RentedProduct rentedProducts = new RentedProduct(id, rent, items, quantity, totalPrice);
                    renteds.Add(rentedProducts);
                    }
                    
                }
                conn.Close();
                return renteds;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
