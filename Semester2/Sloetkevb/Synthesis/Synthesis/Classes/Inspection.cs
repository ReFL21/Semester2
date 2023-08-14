using System;
using System.Collections.Generic;
using System.Text;

namespace SynthesisAssignment.classes
{
   public class Inspection
    {
        private int id;
        private DateTime date;
        private Rent rent;
        private Worker worker;
        private string note;

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
        public Rent Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        public Worker Worker
        {
            get { return worker; }
            set { worker = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        public Inspection(DateTime date, Rent rent, Worker worker, string note)
        {
            this.date = date;
            this.rent = rent;
            this.worker = worker;
            this.note = note;
        
        }
        public Inspection(int id, DateTime date, Rent rent, Worker worker, string note)
        {
            this.id = id;
            this.date = date;
            this.rent = rent;
            this.worker = worker;
            this.note = note;

        }









    }
}
