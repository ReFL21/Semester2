using DuelSysClassLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DuelSysClassLibrary.Interfaces
{
   public interface ISport
    {
        public void AddSport(Sports sport);
        public void DeleteSport(Sports sports);
        public List<Sports> ViewAllSports();
        public Sports GetSportsByID(int id);
        public void UpdateSport(string name, int winningP, int id);
    }
}
