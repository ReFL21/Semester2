using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.FakeData
{
   public class MockDALMatch:IMatch
    {
        static Player player1 = new Player(1, "Ivan");
        static Player player2 = new Player(2, "George");
        static Sports sports = new Sports(1, "Tennis", 7);
        static Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
        static Match match = new Match(1, tournament, player1, player2, 0, 0);
        List<Match> matches = new List<Match>();

        public int ExecuteAddMatch { get; set; }
        public int ExecuteAddScore { get; set; }
        
        public int ExecuteViewMatches { get; set; }
        public void AddMatch(Match match)
        {
            ExecuteAddMatch++;
        }

        public void AddScore(Match match1, int scoreplayer1, int scoreplayer2)
        {
            if (match.ID == match1.ID && match.Tournament.ID == match1.Tournament.ID)
            {
                if (scoreplayer1> sports.WinningPoints || scoreplayer2> sports.WinningPoints)
                {
                    match.ScorePlayer1 = -1;
                    match.ScorePlayer2 = -1;
                }
                else
                {
                    match.ScorePlayer1 = match.ScorePlayer1 + scoreplayer1;
                    match.ScorePlayer2 = match.ScorePlayer2 + scoreplayer2;
                }
            }
            else
            {
                match.ScorePlayer1 = -1;
                match.ScorePlayer2 = -1;
            }
        
        }
        public List<Match> ViewMatches()
        {
            ExecuteViewMatches++;
            matches.Add(match);
            return matches;
        }


        public List<Match> ViewmatchesByTournament(int id)
        {
            List<Match> matches1 = new List<Match>();
            foreach (Match item in ViewMatches())
            {
                if (item.Tournament.ID == id)
                {
                    matches1.Add(item);
                }

            }
            return matches1;
        }







    }
}
