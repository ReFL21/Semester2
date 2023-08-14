using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class Items
    {
        private int id;
        private string name;
        private int deposit;
        private int costPer2Hous;
        private int quantity;
        private string remark;
        Location location;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public int CostPer2Hous
        {
            get { return costPer2Hous; }
            set { costPer2Hous = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public Items(string name, int deposit, int costPer2Hour, int quantity, string remark, Location location)
        {

            this.name = name;
            this.deposit = deposit;
            this.costPer2Hous = costPer2Hour;
            this.quantity = quantity;
            this.remark = remark;
            this.location = location;
        
        }

        public Items(int id, string name, int deposit, int costPer2Hour, int quantity, string remark, Location location)
        {
            this.id = id;
            this.name = name;
            this.deposit = deposit;
            this.costPer2Hous = costPer2Hour;
            this.quantity = quantity;
            this.remark = remark;
            this.location = location;
        }

        public Items()
        {
        }
    }
}
