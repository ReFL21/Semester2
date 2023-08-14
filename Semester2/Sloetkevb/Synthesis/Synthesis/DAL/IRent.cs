using Synthesis.Classes;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
    public interface IRent
    {
        public void AddRent(Rent rent);

        public void UpdateRent(int id, DateTime date, DateTime Startdate, DateTime Enddate, Location location);

        public void EndRent(Rent rent, RentalStatus status);

        public List<Rent> ViewAllRents();
        public void AddBoatsToRent(RentedProduct rentedProducts);
        public void AddItemsTORent(RentedProduct rentedProducts);

        public List<RentedProduct> ViewRentedBoats(int Rentid);
        public List<RentedProduct> ViewRentedItems(int Rentid);
    }
}
