using Synthesis.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
	public class Rent
	{
		int id;
		DateTime date;
		DateTime startingDate;
		DateTime endDate;
		People person;
		List<Boat> boats;
		List<Items> items;
		Location location;
		int price;
		string note;
		RentalStatus status;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		public DateTime Date
		{
			get { return date; }
			set { date = value; }
		}
		public DateTime StartingDate
		{
			get { return startingDate; }
			set { startingDate = value; }
		}
		public DateTime EndDate
		{
			get { return endDate; }
			set { endDate = value; }
		}
		public People Person
		{
			get { return person; }
			set { person = value; }
		}
		public int Price
		{
			get { return price; }
			set { price = value; }
		}
		public string Note
		{
			get { return note; }
			set { note = value; }
		}
		public RentalStatus Status
		{
			get { return status; }
			set { status = value; }
		}
		public Location Location
		{
			get { return location; }
			set { location = value; }
		}

		public List<Boat> Boats
		{
			get { return boats; }
			set { boats = value; }
		}

		public List<Items> Items
		{
			get { return items; }
			set { items = value; }
		}

		public Rent(DateTime date, DateTime startingDate, DateTime endDate, People person, string note, Location location)
		{
			this.date = date;
			this.startingDate = startingDate;
			this.endDate = endDate;
			this.person = person;
			this.note = note;

			this.status = (RentalStatus)0;
			this.location = location;
			this.boats = new List<Boat>();
			this.items = new List<Items>();
		}

		public Rent(int id, DateTime date, DateTime startingDate, DateTime endDate, People person, string note, RentalStatus status, Location location)
		{
			this.id = id;
			this.date = date;
			this.startingDate = startingDate;
			this.endDate = endDate;
			this.person = person;
			this.note = note;
			this.status = status;
			this.location = location;
			this.boats = new List<Boat>();
			this.items = new List<Items>();
		}
		public Rent() { }

		public override string ToString()
		{
			return $"ID:{id}, StartDate{startingDate}, EndDate:{endDate}, Date{date}";
		}
	}
}
