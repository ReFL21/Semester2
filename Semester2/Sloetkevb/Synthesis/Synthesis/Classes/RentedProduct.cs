using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Classes
{
   public class RentedProduct
    {
        private int id;
        private Rent rent;
        private Boat boat;
        private Items items;
        private int quantity;
        private int totalPrice;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public Rent Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        public Boat Boat
        {
            get { return boat; }
            set { boat = value; }
        }
        public Items Items
        {
            get { return items; }
            set { items = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        public RentedProduct(Rent rent, Boat boat, int quantity, int totalPrice)
        {
            this.rent = rent;
            this.boat = boat;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
        public RentedProduct(Rent rent, Items items, int quantity, int totalPrice)
        {
            this.rent = rent;
            this.items = items;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }

        public RentedProduct(int id, Rent rent, Boat boat, int quantity, int totalPrice)
        {
            this.id = id;
            this.rent = rent;
            this.boat = boat;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
        public RentedProduct(int id, Rent rent, Items items, int quantity, int totalPrice)
        {
            this.id = id;
            this.rent = rent;
            this.items = items;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
    }
}
