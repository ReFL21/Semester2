using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
    public class Worker:People
    {
        Location location;

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }
        public Worker( string name, string username, string password, string address, string city, string email, Location location) :base( name, username, password, address, city, email)
        {
            this.location = location;
        }
        public Worker(int  id, string name, string username, string password, string address, string city, string email, Location location) : base(id,name, username, password, address, city, email)
        {
            this.location = location;
        }


    }
}
