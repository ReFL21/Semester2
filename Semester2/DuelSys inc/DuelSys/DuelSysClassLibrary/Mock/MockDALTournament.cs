using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.FakeData
{
    public class MockDALTournament : ITournament
    {
        static Player player1 = new Player(1, "Ivan");
        static Player player2 = new Player(2, "George");
        static Sports sports = new Sports(1, "Tennis", 7);
        static Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
        List<Tournament> tournaments = new List<Tournament>();
       public static int points = 0;

        public int ExecuteAddTournament { get; set; }
        public int ExecuteDeleteTournament { get; set; }
        public int ExecuteGetTournament { get; set; }
        public int ExecuteGetAllTournament { get; set; }
        public int ExecuteGetPlayersforTournament { get; set; }
        public int ExecuteUpdateStatus { get; set; }
        public int ExecuteAddPoints { get; set; }

        public void AddTournament(Tournament tournament)
        {
            ExecuteAddTournament++;
        }

        public void DeleteTournament(Tournament tournament)
        {
            ExecuteDeleteTournament++;
        }

        public Tournament GetTournament(int id)
        {
            if (tournament.ID == id)
            {
                return tournament;
            }
            return null;
        }

        public List<Tournament> GetAllTournament()
        {
            ExecuteGetAllTournament++;
            tournaments.Add(tournament);
            return tournaments;
        }

        public List<Player> GetPlayersForTournament(Tournament tournament1)
        {
            if (tournament.ID == tournament1.ID)
            {
                tournament.Players.Add(player1);
                tournament.Players.Add(player2);
                return tournament.Players;
            }
            return null;
        
        }

        public void UpdateStatus(Tournament tournament1, Status status)
        {
            if (tournament.ID == tournament1.ID)
            {
                ExecuteUpdateStatus++;
                 tournament.Status = status;
            }
            
        }


        public void AddPoints(Tournament tournament1, Player player)
        {
            if (tournament.ID == tournament1.ID && player.ID == player1.ID)
            {
                ExecuteAddPoints++;
                points = 1;
            }
           
        }

        public void UpdateTournament(DateTime startDate, DateTime endDate, string city, string address, int minplayers, int maxplayers, int id)
        {
            if (tournament.ID == id && startDate < endDate && minplayers < maxplayers)
            {
              
                    tournament.Startdate = startDate;
                    tournament.Enddate = endDate;
                    tournament.City = city;
                    tournament.Address = address;
                    tournament.Minplayers = minplayers;
                    tournament.Maxplayers = maxplayers;
              
               
            }
        
        
        }

    }
}
