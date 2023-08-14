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
    public class SportTests
    {

        [TestMethod]
        public void ViewSports()
        {
            Sports sport = new Sports(1, "Tennis", 7);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);
            List<Sports> sports = sportManager.ViewAllSports();
            Assert.IsTrue(sports.Count > 0);

        }


        [TestMethod]
        public void GetSportByID()
        {
            Sports sport = new Sports(1, "Tennis", 7);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);
            Sports sports = sportManager.GetSportByID(1);
            Assert.IsNotNull(sports);
        }

        [TestMethod]
        public void GetSportWithWrongID()
        {
            Sports sport = new Sports(1, "Tennis", 7);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);
            Sports sports = sportManager.GetSportByID(5);
            Assert.IsNull(sports);

        }

        [TestMethod]
        public void UpdateSport()
        {
            Sports sport = new Sports(1, "Tennis", 7);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);

            sportManager.UpdateSport("Table Tennis", 11, 1);
            Sports sports = sportManager.GetSportByID(1);
            Assert.AreEqual("Table Tennis", sports.Name);
        }

        [TestMethod]
        public void UpdateSportWrongID()
        {
            Sports sport = new Sports(1, "Table Tennis", 7);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);

            sportManager.UpdateSport("Tennis", 11, 7);
            Sports sports = sportManager.GetSportByID(1);
            Assert.AreNotEqual("Tennis", sports.Name);
        }

        [TestMethod]
        public void UpdateSportWrongName()
        {
            Sports sport = new Sports(1, "Table Tennis", 11);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);

            sportManager.UpdateSport("", 11, 1);
            Sports sports = sportManager.GetSportByID(1);
            Assert.AreEqual("Table Tennis", sports.Name);
        }

        [TestMethod]
        public void UpdateSportWrongPoints()
        {
            Sports sport = new Sports(1, "Table Tennis", 11);
            SportManager sportManager = new SportManager(new MockDALSport());
            sportManager.AddSport(sport);

            sportManager.UpdateSport("Tennis", -1, 1);
            Sports sports = sportManager.GetSportByID(1);
            Assert.AreNotEqual(-1, sports.WinningPoints);

        }

    }
}
