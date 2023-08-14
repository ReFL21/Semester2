using Synthesis.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class Customer:People
    {
        int phoneNumber;


        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public Customer() { }
        public Customer(string name, string username, string password, string address, string city, string email, int phoneNumber) :base(name, username, password, address, city, email)
        {
            this.phoneNumber = phoneNumber;
        }

        public Customer(int id, string name, string username, string password, string address, string city, string email, int phoneNumber) : base(id, name, username, password, address, city, email)
        {
            this.phoneNumber = phoneNumber;
        }



    }
}
