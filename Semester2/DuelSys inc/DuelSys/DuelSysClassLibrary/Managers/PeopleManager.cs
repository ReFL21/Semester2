using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary.Managers
{
    public class PeopleManager
    {
        public IPeople iPeople;
        public PeopleManager(IPeople people)
        {
            this.iPeople = people;
        }
        public void Register(People people)
        {
            iPeople.AddPeople(people);
        }

        public People GetPerson(int id)
        {
            People people = iPeople.GetPerson(id);
            return people;
        }

        public List<People> ViewAllPeople()
        {
            List<People> peoples = iPeople.ViewAllPeople();
            return peoples;
        }

        public DataTable ViewStaff()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Name"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Username"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Password"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Email"), typeof(string)));

            foreach (People item in ViewAllPeople())
            {
                if (item is Staff)
                {
                    var row = dt.NewRow();
                    row["ID"] = item.ID;
                    row["Name"] = item.Name;
                    row["Username"] = item.Username;
                    row["Password"] = item.Password;
                    row["Email"] = item.Email;
                    dt.Rows.Add(row);
                }

            }
            return dt;
        }

        public int CheckUser(string username, string pass)
        {
            var check = iPeople.CheckUser(username, pass);
            if (check != -1)
            {
                return check;
            }
            else
            {
                return -1;
            }

        }

        public int IsTaken(string username)
        {
            if (iPeople.IsTaken(username) == false)
            {
                return 1;
            }
            return -1;
        }

        public void RegisterForTournament(Player player, Tournament tournament)
        {
            iPeople.RegisterForTournament(player, tournament);
        }

        public int RetreiveTournamentID(Player player)
        {
            int tid = iPeople.RetrieveTournamentID(player.ID);
            if (tid != -1)
            {
                return tid;
            }
            else
            {
                return -1;
            }
        
        }



        public List<People> ViewStaffMembers()
        {
            List<People> staffs = new List<People>();
            foreach (People item in iPeople.ViewAllPeople())
            {
                if (item is Staff)
                {
                    staffs.Add(item);
                }
            }
            return staffs;
        }


        public void DeleteStaff(People people)
        {
            iPeople.DeleteStaff(people);
        }
    }
}
