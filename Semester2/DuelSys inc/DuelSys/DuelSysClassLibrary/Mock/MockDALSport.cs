using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.FakeData
{
    public class MockDALSport : ISport
    {
        static Sports sport = new Sports(1, "Tennis", 7);
        List<Sports> sports = new List<Sports>();
        public int ExecuteAddSport { get; set; }
        public int ExecuteDeleteSport { get; set; }
        public int ExecuteViewAllSport { get; set; }
        public int ExecuteGetSportByID { get; set; }

        public void AddSport(Sports sport)
        {
            ExecuteAddSport++;

        }
        public void DeleteSport(Sports sports)
        {
            ExecuteDeleteSport++;
        }

        public List<Sports> ViewAllSports()
        {
            ExecuteViewAllSport++;
            sports.Add(sport);
            return sports;
        }
        public Sports GetSportsByID(int id)
        {
            if (sport.ID == id)
            {
                return sport;
            }
            else
            {
                return null;
            }
        }

        public void UpdateSport(string name, int winnignP, int id)
        {
            if (sport.ID == id)
            {
                if (winnignP>0 && name!= "")
                {
                    sport.Name = name;
                    sport.WinningPoints = winnignP;
                }
                
            }
        }


    }
}
