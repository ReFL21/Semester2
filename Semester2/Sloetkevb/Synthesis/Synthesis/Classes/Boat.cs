using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class Boat
    {
        private int id;
        private string type;
        private int quantity;
        private int costPer2Hours;
        private string remark;
        private int deposit;
        private int capacity;
        private Location location;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public int CostPer2Hours
        {
            get { return costPer2Hours; }
            set { costPer2Hours = value; }
        }

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public int Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public Boat(string type, int quantity, int costPer2Hours, string remark, int deposit, int capacity, Location location)
        {
            this.type = type;
            this.quantity = quantity;
            this.costPer2Hours = costPer2Hours;
            this.remark = remark;
            this.deposit = deposit;
            this.capacity = capacity;
            this.location = location;

        }

        public Boat(int id, string type, int quantity, int costPer2Hours, string remark, int deposit, int capacity, Location location)
        {
            this.id = id;
            this.type = type;
            this.quantity = quantity;
            this.costPer2Hours = costPer2Hours;
            this.remark = remark;
            this.deposit = deposit;
            this.capacity = capacity;
            this.location = location;
        }
        public Boat() { }
    }
}
