using Synthesis.Classes;
using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
    public class FakeDALRent : IRent
    {
        public int ExecutionAddRCount { get; set; }
        public int ExecutionEndCount { get; set; }
        public int ExecutionViewAllRCount { get; set; }
        public int ExecutionViewAllRPCount { get; set; }
        public int ExecutionAddBRCount { get; set; }
        public int ExecutionEditCount { get; set; }
        public int ExecutionAddIRCount { get; set; }
        public void AddBoatsToRent(RentedProduct rentedProducts)
        {
            ExecutionAddBRCount++;
        }

        public void AddItemsTORent(RentedProduct rentedProducts)
        {
            ExecutionAddIRCount++;
        }

        public void AddRent(Rent rent)
        {
            ExecutionAddRCount++;
        }

        public void EndRent(Rent rent, RentalStatus status)
        {
            ExecutionEndCount++;
        }

        public void UpdateRent(int id, DateTime date, DateTime Startdate, DateTime Enddate, Location location)
        {
            ExecutionEditCount++;
        }

        public List<Rent> ViewAllRents()
        {
            ExecutionViewAllRCount++;
            List<Rent> rents = new List<Rent>();
            return rents;
        }

        public List<RentedProduct> ViewRentedBoats(int Rentid)
        {
            throw new NotImplementedException();
        }

        public List<RentedProduct> ViewRentedItems(int Rentid)
        {
            throw new NotImplementedException();
        }

        public List<RentedProduct> ViewRentProducts(int Rentid)
        {
            ExecutionViewAllRPCount++;
            List<RentedProduct> rentedProducts = new List<RentedProduct>();
            return rentedProducts;
        }
    }
}
