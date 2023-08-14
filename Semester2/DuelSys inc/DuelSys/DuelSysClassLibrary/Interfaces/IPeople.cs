using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Interfaces
{
   public interface IPeople
    {
        public void AddPeople(People people);
        public People GetPerson(int id);
        public List<People> ViewAllPeople();
        public bool IsTaken(string username);
        public int CheckUser(string user, string pass);
        public int RetrieveTournamentID(int id);
        public void RegisterForTournament(Player player, Tournament tournament);
        public void DeleteStaff(People people);


    }
}
