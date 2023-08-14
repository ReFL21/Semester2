using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Interfaces
{
   public interface ITournament
    {
        public void AddTournament(Tournament tournament);
        public void DeleteTournament(Tournament tournament);
        public Tournament GetTournament(int id);
        public List<Tournament> GetAllTournament();
        public List<Player> GetPlayersForTournament(Tournament tournament);
        public void UpdateStatus(Tournament tournament, Status status);
        public void AddPoints(Tournament tournament, Player player);
        public void UpdateTournament(DateTime startDate, DateTime endDate, string city, string address, int minplayers, int maxplayers, int id);
    }
}
