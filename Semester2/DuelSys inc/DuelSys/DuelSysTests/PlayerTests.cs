using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.FakeData;
using DuelSysClassLibrary.Managers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysTests
{
    [TestClass]
    public class PeopleTests
    {
        [TestMethod]
        public void GetPersonByID()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            peoplemanager.Register(people);
            peoplemanager.ViewAllPeople();
            People people1 = peoplemanager.GetPerson(1);
            Assert.IsTrue(people1.Name == "Ivan");
        }

        [TestMethod]
        public void GetPersonByWrongID()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            peoplemanager.Register(people);
            peoplemanager.ViewAllPeople();
            People people1 = peoplemanager.GetPerson(5);
            Assert.IsNull(people1);
        }

        [TestMethod]
        public void IsTakenUsername()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            int result= peoplemanager.IsTaken(people.Username);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void IsTakenUsernameWrong()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "brejka", "asdasd", "Ivna12@gmail.com");
            int result = peoplemanager.IsTaken(people.Username);
            Assert.AreEqual(result, 1);

        }

        [TestMethod]
        public void CheckUser()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            peoplemanager.Register(people);
           int result= peoplemanager.CheckUser(people.Username, people.Password);
            Assert.AreEqual(result,1);

        }

        [TestMethod]
        public void CheckUserWrongUsername()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            peoplemanager.Register(people);
            int result = peoplemanager.CheckUser("asdgfahd", people.Password);
            Assert.AreEqual(result, -1);
        }

        [TestMethod]
        public void CheckUserWrongPassword()
        {
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            People people = new People(1, "Ivan", "qwerty", "asdasd", "Ivna12@gmail.com");
            peoplemanager.Register(people);
            int result = peoplemanager.CheckUser(people.Username, "qew1625");
            Assert.AreEqual(result, -1);

        }

        [TestMethod]
        public void RetrieveTournamentID()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            Player player = new Player(2, "Plamena");
            peoplemanager.Register(player);
            peoplemanager.RegisterForTournament(player, tournament);
            int result = peoplemanager.RetreiveTournamentID(player);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void RetrieveTournamentIDWrongPlayer()
        {
            Sports sports = new Sports(1, "Tennis", 7);
            Tournament tournament = new Tournament(1, "fun", DateTime.Now, DateTime.Now, "Varna", "this street", 6, 8, sports, Status.Availible);
            PeopleManager peoplemanager = new PeopleManager(new MockDALPeople());
            Player player = new Player(2, "Plamena");
            Player player1 = new Player(5, "Kamelia");
            peoplemanager.Register(player);
            peoplemanager.RegisterForTournament(player, tournament);
            int result = peoplemanager.RetreiveTournamentID(player1);
            Assert.AreNotEqual(result, 1);
        }



    }
}
