using DuelSysClassLibrary.Classes;
using DuelSysClassLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DuelSysClassLibrary.Managers
{
   public class SportManager
    {
        ISport isport;

        public SportManager(ISport sport)
        {
            this.isport = sport;
        }

        public void AddSport(Sports sports)
        {
            isport.AddSport(sports);
        }

        public List<Sports> ViewAllSports()
        {
            List<Sports> sports = isport.ViewAllSports();
            return sports;
        }

        public DataTable ViewSports()
        {
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Name"), typeof(string)));
            dt.Columns.Add(new DataColumn(("WinningPoints"), typeof(int)));
            foreach (var item in ViewAllSports())
            {
                var row = dt.NewRow();
                row["ID"] = item.ID;
                row["Name"] = item.Name;
                row["WinningPoints"] = item.WinningPoints;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public void DeleteSport(Sports sports)
        {
            isport.DeleteSport(sports);
        
        }
        public Sports GetSportByID(int id)
        {
           Sports sports= isport.GetSportsByID(id);
            if (sports ==null)
            {
                return null;
            }
            else
            {
                
                return sports;
            }
        }
        public void UpdateSport(string name, int winningP, int id)
        {
            isport.UpdateSport(name, winningP, id);
        }

    }
}
