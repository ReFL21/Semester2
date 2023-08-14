
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class People
    {
		int id;
		string name;
		string username;
		string password;
		string address;
		string city;
		string email;


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
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string Address
		{
			get { return address; }
			set { address = value; }
		}
		public string City
		{
			get { return city; }
			set { city = value; }
		}
		public string Email
		{
			get { return email; }
			set { email = value; }
		}
		public People(int id, string name, string username, string password, string address, string city, string email)
		{
			this.id = id;
			this.name = name;
			this.username = username;
			this.password = password;
			this.address = address;
			this.city = city;
			this.email = email;
		}

		public People(string name, string username, string password, string address, string city, string email)
		{
			this.name = name;
			this.username = username;
			this.password = password;
			this.address = address;
			this.city = city;
			this.email = email;
		}

		public People() { }
	}
}
