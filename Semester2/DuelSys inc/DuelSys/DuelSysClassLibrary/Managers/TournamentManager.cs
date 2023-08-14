using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary.Managers
{
   public class TournamentManager
    {
       public ITournament iTournament;
        public TournamentManager(ITournament tournament)
        {
            this.iTournament = tournament;
        }

        public void CreateTournament(Tournament tournament)
        {
            iTournament.AddTournament(tournament);       
        }

        public void DeleteTournament(Tournament tournament)
        {
            iTournament.DeleteTournament(tournament);
        }

        public List<Tournament> ViewAllTournaments()
        {
            List<Tournament> tournaments = iTournament.GetAllTournament();
            return tournaments;
        }

        public DataTable ViewTournaments()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("StartingDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("EndDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Address"), typeof(string)));
            dt.Columns.Add(new DataColumn(("MinPlayers"), typeof(int)));
            dt.Columns.Add(new DataColumn(("MaxPlayers"), typeof(int)));
            dt.Columns.Add(new DataColumn(("SportName"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Status"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Description"), typeof(string)));

            foreach (Tournament item in ViewAllTournaments())
            {
                var row = dt.NewRow();
                row["ID"] = item.ID;
                row["StartingDate"] = item.Startdate;
                row["EndDate"] = item.Enddate;
                row["City"] = item.City;
                row["Address"] = item.Address;
                row["MinPlayers"] = item.Minplayers;
                row["MaxPlayers"] = item.Maxplayers;
                row["SportName"] = item.Sport.Name;
                row["Status"] = item.Status;
                row["Description"] = item.Description;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DataTable ShowFilteredTournaments(Status status)
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("StartingDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("EndDate"), typeof(DateTime)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Address"), typeof(string)));
            dt.Columns.Add(new DataColumn(("MinPlayers"), typeof(int)));
            dt.Columns.Add(new DataColumn(("MaxPlayers"), typeof(int)));
            dt.Columns.Add(new DataColumn(("SportName"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Status"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Description"), typeof(string)));

            foreach (Tournament item in ViewAllTournaments())
            {
                if (item.Status == status)
                {                
                    var row = dt.NewRow();
                    row["ID"] = item.ID;
                    row["StartingDate"] = item.Startdate;
                    row["EndDate"] = item.Enddate;
                    row["City"] = item.City;
                    row["Address"] = item.Address;
                    row["MinPlayers"] = item.Minplayers;
                    row["MaxPlayers"] = item.Maxplayers;
                    row["SportName"] = item.Sport.Name;
                    row["Status"] = item.Status;
                    row["Description"] = item.Description;
                    dt.Rows.Add(row);
                }
            }
            return dt;

        }

        public Tournament GetTournament(int id)
        {
             
            var check = iTournament.GetTournament(id);
            if (check != null)
            {
                Tournament tournament  = check;
                return tournament;
            }
            else
            {
                return null;
            }
           
            
        }
        public List<Player> PlayersForTournament(Tournament tournament)
        {
            List<Player> players = iTournament.GetPlayersForTournament(tournament);
            
            return players;
        }
        public void AddPoints(Tournament tournament, Player player)
        {   
          iTournament.AddPoints(tournament, player);
        }

        public void UpdateStatus(Tournament tournament, Status status)
        {
            iTournament.UpdateStatus(tournament, status);
        }

        public List<Tournament> ViewFilteredTournamentByStatus(Status status)
        {
            List<Tournament> tournaments = new List<Tournament>();
            foreach (Tournament item in iTournament.GetAllTournament())
            {
                if (item.Status == status)
                {
                    tournaments.Add(item);
                }
            }
            return tournaments;

        }

        public void UpdateTournament(DateTime startDate, DateTime endDate, string city, string address, int minplayers, int maxplayers, int id)
        {
            iTournament.UpdateTournament(startDate, endDate, city, address, minplayers, maxplayers, id);
        }



    }
}
