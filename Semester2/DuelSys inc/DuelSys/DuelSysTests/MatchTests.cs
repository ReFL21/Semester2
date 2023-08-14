using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.FakeData;
using DuelSysClassLibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DuelSysTests
{
    [TestClass]
    public class MatchTests
    {
        [TestMethod]
        public void AddScoreToMatch()
        {
            MatchManager matchManager = new MatchManager(new MockDALMatch());
            Player player1 = new Player(1, "Ivan");
            Player player2 = new Player(2, "George");
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            Match match = new Match(1, tournament, player1, player2, 0, 0);
            matchManager.CreateMatch(match);
            matchManager.ViewAllmatches();
            matchManager.AddScore(match, 7, 5);
            Match match1 = matchManager.ViewAllmatches().Last();
            Assert.IsTrue(match1.ScorePlayer1 == 7);
            Assert.IsTrue(match1.ScorePlayer2 == 5);
        }

        [TestMethod]
        public void AddScoreWrongPoints()
        {
            MatchManager matchManager = new MatchManager(new MockDALMatch());
            Player player1 = new Player(1, "Ivan");
            Player player2 = new Player(2, "George");
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            Match match = new Match(1, tournament, player1, player2, 0, 0);
            matchManager.CreateMatch(match);
            matchManager.ViewAllmatches();
            matchManager.AddScore(match, 9,10);
            Match match1 = matchManager.ViewAllmatches().Last();
            Assert.IsTrue(match1.ScorePlayer1 < 0);
            Assert.IsTrue(match1.ScorePlayer2 < 0);


        }

        [TestMethod]
        public void AddScoreWrongTournament()
        {
            MatchManager matchManager = new MatchManager(new MockDALMatch());
            Player player1 = new Player(1, "Ivan");
            Player player2 = new Player(2, "George");
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(5, "fun", DateTime.Now, DateTime.Now, "Varna", "that street", 8, 10, sports, Status.Availible);
            Match match = new Match(1, tournament, player1, player2, 0, 0);
            matchManager.CreateMatch(match);
            matchManager.ViewAllmatches();
            matchManager.AddScore(match, 7, 5);
            Match match1 = matchManager.ViewAllmatches().Last();
            Assert.IsTrue(match1.ScorePlayer1 < 0);
            Assert.IsTrue(match1.ScorePlayer2 < 0);
        }





        [TestMethod]
        public void GetMatchesByTournament()
        {
            MatchManager matchManager = new MatchManager(new MockDALMatch());
            Player player1 = new Player(1, "Ivan");
            Player player2 = new Player(2, "George");
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            Match match = new Match(1, tournament, player1, player2, 0, 0);
            matchManager.CreateMatch(match);
            List<Match> list= matchManager.ViewMatchesByTournament(1);
            Assert.IsTrue(list.Count>0);
        }

        [TestMethod]
        public void GetMatchesByWrongTournament()
        {
            MatchManager matchManager = new MatchManager(new MockDALMatch());
            Player player1 = new Player(1, "Ivan");
            Player player2 = new Player(2, "George");
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            Match match = new Match(1, tournament, player1, player2, 0, 0);
            matchManager.CreateMatch(match);
            List<Match> list = matchManager.ViewMatchesByTournament(5);
            Assert.IsTrue(list.Count == 0);
        }

    }
}
