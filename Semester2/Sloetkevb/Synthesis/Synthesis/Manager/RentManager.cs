using Synthesis.Classes;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
    public class RentManager
    {
        IRent rentDAL;
        public RentManager(IRent rent)
        {
            this.rentDAL = rent;
        }

        public RentManager()
        {
        }

        public void AddRent(Rent rent)
        {
            rentDAL.AddRent(rent);
        }
        public void EndRent(Rent rent, RentalStatus status)
        {
            rentDAL.EndRent(rent, status);
        }

        public void UpdateRent(int id, DateTime date, DateTime Startdate, DateTime Enddate, Location location)
        {
            rentDAL.UpdateRent(id, date, Startdate, Enddate, location);
        
        }

        public List<Rent> ViewRents()
        {
            List<Rent> rents = rentDAL.ViewAllRents();
            return rents;
        }

        public DataTable ViewAllRent()
        {
            rentDAL.ViewAllRents();
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Date"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("StartDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("EndDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("CustomerID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Note"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Status"), typeof(string)));
            dt.Columns.Add(new DataColumn(("LocationID"), typeof(int)));
            foreach (Rent item in rentDAL.ViewAllRents())
            {
                var row = dt.NewRow();
                row["ID"] = item.ID;
                row["Date"] = item.Date;
                row["StartDate"] = item.StartingDate;
                row["EndDate"] = item.EndDate;
                row["CustomerID"] = item.Person.ID;
                row["Note"] = item.Note;
                row["Status"] = item.Status.ToString();
                row["LocationID"] = item.Location.ID;
                dt.Rows.Add(row);
            }
            return dt;
        }


        public void AddBoatsToRent(RentedProduct rentedProducts)
        {
            rentDAL.AddBoatsToRent(rentedProducts);
        
        }

        public void AddItemsToRent(RentedProduct rentedProducts)
        {
            rentDAL.AddItemsTORent(rentedProducts);
        
        }
        public List<RentedProduct> ViewRentedBoats(Rent rent)
        {
            List<RentedProduct> rentedProducts = rentDAL.ViewRentedBoats(rent.ID);
            return rentedProducts;
        }
        public List<RentedProduct> ViewRentedItems(Rent rent)
        {
            List<RentedProduct> rentedProducts = rentDAL.ViewRentedItems(rent.ID);
            return rentedProducts;
        }
        public DataTable ViewProductsByRent(Rent rent)
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("RentId"), typeof(int)));
            dt.Columns.Add(new DataColumn(("ProductID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Quantity"), typeof(int)));
            dt.Columns.Add(new DataColumn(("TotalPrice"), typeof(int)));
;
            foreach (RentedProduct item in rentDAL.ViewRentedBoats(rent.ID))
            {
                var row = dt.NewRow();
                row["ID"] = item.ID;
                row["RentId"] = item.Rent.ID;
                row["ProductID"] = item.Boat.ID;             
                row["Quantity"] = item.Quantity;
                row["TotalPrice"] = item.TotalPrice;
                dt.Rows.Add(row);
            }
            foreach (RentedProduct item in rentDAL.ViewRentedItems(rent.ID))
            {
                var row = dt.NewRow();
                row["ID"] = item.ID;
                row["RentId"] = item.Rent.ID;
                row["ProductID"] = item.Boat.ID;
                row["Quantity"] = item.Quantity;
                row["TotalPrice"] = item.TotalPrice;
                dt.Rows.Add(row);
            }
            return dt;


        }

    }
}
