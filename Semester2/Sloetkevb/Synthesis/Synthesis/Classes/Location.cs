using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class Location
    {
        private int id;
        private string name;
        private string city;
        private string address;

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
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public Location() { }
        public Location(string name, string city, string address)
        {
            this.name = name;
            this.city = city;
            this.address = address;
        }
        public Location(int id, string name, string city, string address)
        {
            this.id = id;
            this.name = name;
            this.city = city;
            this.address = address;
        }

        public string ToString()
        {
            string info = $"ID:{id}, City:{city}";
            return info;
        }
    }
}
