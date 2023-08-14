
using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.FakeData
{
   public class MockDALPeople:IPeople
    {
       static People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
        Player player = new Player(2, "Plamena");
        Player player1 = new Player(5, "Kamelia");
        List<People> peoples = new List<People>();
       static Sports sports = new Sports(1, "Tennis", 7);
       static Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
        List<Player> players = new List<Player>();

        public int ExecuteRegister { get; set; }
        public int ExecuteGetUbyID { get; set; }
        public int ExecuteCheckUser { get; set; }
        public int ExecuteViewUsers { get; set; }
        public int ExecuteIsTaken { get; set; }
        public int ExecuterRegisterForTournament { get; set; }
        public int ExecuteRetrieveTournamentID { get; set; }
        public int ExecuteDeleteStaff { get; set; }

        public void AddPeople(People people)
        {
            ExecuteRegister++;
        }
        public People GetPerson(int id)
        {
            ExecuteGetUbyID++;
            if (people.ID == id)
            {
                return people;
            }
            return null;
        }
        public int CheckUser(string user, string pass)
        {
            
            if (people.Username == user && people.Password == pass)
            {
                ExecuteCheckUser++;
                return 1;
            }
            return -1;
        }
        public List<People> ViewAllPeople()
        {
            peoples.Add(people);
            ExecuteViewUsers++;
            return peoples;
        }

        public bool IsTaken(string username)
        {
           
            if (people.Username == username)
            {
                ExecuteIsTaken++;
                return true;
            }
            return false;
        }
        public int RetrieveTournamentID(int id)
        {
            players.Add(player);
                foreach (var item in players)
                {
                    if (item.ID == id)
                    {
                    ExecuteRetrieveTournamentID++;
                        return tournament.ID;
                    }
                }
            
            return -1;
        }

        public void RegisterForTournament(Player player2, Tournament tournament1)
        {
            ExecuterRegisterForTournament++;
           
        }

        public void DeleteStaff(People people)
        {
            ExecuteDeleteStaff++;
        }
    }
}
