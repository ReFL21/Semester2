using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
    public class PeopleManager
    {
     
        IPeople peopleDAL;
        List<Worker> logedWorker = new List<Worker>();
        public PeopleManager(IPeople people)
        {
            this.peopleDAL = people;
        }

        public PeopleManager()
        {
        }

        public int CheckUser(string user, string pass)
        {
            var check = peopleDAL.CheckUser(user, pass);
            if (check != -1)
            {
                return check;
            }
            else
            {
                return -1;
            }
        }


        public People GetUser(int id)
        {
            People user = peopleDAL.GetUserByID(id);
            if (user != null)
            {
                return user;
            }
            return null;

        }

        public void AddPeople(People people)
        {
            peopleDAL.AddPeople(people);
        }

        public void DeleteWorker(Worker worker)
        {
            peopleDAL.DeleteWorker(worker);
        }

        public DataTable ViewAllPeople()
        {
          //  peopleDAL.ViewAllPeople();
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Name"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Username"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Password"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Address"), typeof(string)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Email"), typeof(string)));
            dt.Columns.Add(new DataColumn(("PhoneNumber"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Location"), typeof(string)));
            foreach (People p in peopleDAL.ViewAllPeople())
            {
                if (p is Worker)
                {
                    var row = dt.NewRow();
                    row["ID"] = p.ID;
                    row["Name"] = p.Name;
                    row["Username"] = p.Username;
                    row["Password"] = p.Password;
                    row["Address"] = p.Address;
                    row["City"] = p.City;
                    row["Email"] = p.Email;
                    row["PhoneNumber"] = 0;
                    row["Location"] = ((Worker)p).Location.ID;
                    dt.Rows.Add(row);
                }
                else if (p is Customer)
                {
                    var row = dt.NewRow();
                    row["ID"] = p.ID;
                    row["Name"] = p.Name;
                    row["Username"] = p.Username;
                    row["Password"] = p.Password;
                    row["Address"] = p.Address;
                    row["City"] = p.City;
                    row["Email"] = p.Email;
                    row["PhoneNumber"] = ((Customer)p).PhoneNumber;
                    row["Location"] = 0;
                    dt.Rows.Add(row);
                }
                
            }
            return dt;
        }
        public List<People> ViewPeople()
        {
            List<People> people = peopleDAL.ViewAllPeople();
            return people;
        
        }

        public void AddLoggedWInList(Worker worker)
        {
            logedWorker.Add(worker);
        }
        public List<Worker> ViewLoggedPerson()
        {
            return logedWorker;
        
        }
    }
}
