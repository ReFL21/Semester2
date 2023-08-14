using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.FakeData;
using DuelSysClassLibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuelSysTests
{
    [TestClass]
    public class TournamentTests
    {
        [TestMethod]
        public void GetTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            Tournament tournament1 = tournamentManager.GetTournament(1);
            Assert.IsNotNull(tournament1);

        }

        [TestMethod]
        public void GetTournamentWrongID()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            Tournament tournament1 = tournamentManager.GetTournament(5);
            Assert.IsNull(tournament1);

        }

        [TestMethod]
        public void GetPlayersForTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            List<Player> players = tournamentManager.PlayersForTournament(tournament);
            Assert.IsTrue(players.Count > 0);

        }

        [TestMethod]
        public void GetPlayersForTournamentWrongTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            Tournament tournament1 = new Tournament(2, "asdasd", DateTime.Now, DateTime.Now, "Eindhoven", "That Street", 5, 5, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            List<Player> players = tournamentManager.PlayersForTournament(tournament1);
            Assert.IsNull(players);
        }

        [TestMethod]
        public void UpdateTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            tournamentManager.UpdateTournament(DateTime.Now, DateTime.Now, "Ruse", "this street", 9, 10,1);
            Tournament tournament1 = tournamentManager.GetTournament(1);
            Assert.AreNotEqual("Varna", tournament1.City);
        }

        [TestMethod]
        public void UpdateTournamentWrongTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Ruse", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            tournamentManager.UpdateTournament(DateTime.Now, DateTime.Now, "Varna", "this street", 9, 10, 2);
            Tournament tournament3 = tournamentManager.GetTournament(1);
            Assert.AreNotEqual(tournament3.City , "Varna");
        }

        [TestMethod]
        public void UpdateTournamentWrongDate()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            var date1 = new DateTime(2022, 5, 6, 0, 0, 0);
            tournamentManager.UpdateTournament(DateTime.Now, date1, "Ruse", "this street", 9, 10, 1);
           Tournament tournament1= tournamentManager.GetTournament(1);
            Assert.AreNotEqual(date1,tournament1.Enddate);
        }

        [TestMethod]
        public void UpdateTournamentWrongMINandMAXNumbers()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            tournamentManager.UpdateTournament(DateTime.Now, DateTime.Now, "Ruse", "this street", 20, 10, 1);
            Tournament tournament1 = tournamentManager.GetTournament(1);
            Assert.AreNotEqual(20, tournament1.Minplayers);

        }

        [TestMethod]
        public void UpdateStatus()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            tournamentManager.UpdateStatus(tournament, Status.Finished);
            Tournament tournament1 = tournamentManager.ViewAllTournaments().Last();
            Assert.IsTrue(tournament1.Status == Status.Finished);
        }

        [TestMethod]
        public void UpdateStatusWrongTournament()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(5, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            TournamentManager tournamentManager = new TournamentManager(new MockDALTournament());
            tournamentManager.CreateTournament(tournament);
            tournamentManager.ViewAllTournaments();
            tournamentManager.UpdateStatus(tournament, Status.NonApplicable);
            Tournament tournament1 = tournamentManager.ViewAllTournaments().Last();
            Assert.IsFalse(tournament1.Status == Status.NonApplicable);

        }

    }
}
