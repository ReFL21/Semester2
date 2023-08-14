using Synthesis.DALBoats;
using Synthesis.Test;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
   public class BoatManager
    {
        IBoatDAL boatDAL;
        public BoatManager(IBoatDAL boatDAL)
        {
            this.boatDAL =boatDAL;
        }

        public BoatManager()
        {
        }

        public void AddBoat(Boat boat)
        {
            boatDAL.AddBoat(boat);
        }

        public void DeleteBoat(Boat boat)
        {
            boatDAL.DeleteBoat(boat);
        }
        public List<Boat> ViewAllBoats()
        {
            List<Boat> boats = boatDAL.ViewAllBoats();
            return boats;
        }

        public DataTable ViewBoats()
        {
            boatDAL.ViewAllBoats();
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Type"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Quantity"), typeof(int)));
            dt.Columns.Add(new DataColumn(("PricePer2Hours"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Deposit"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Capacity"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Remark"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Location"), typeof(int)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            foreach (Boat b in boatDAL.ViewAllBoats())
            {
                var row = dt.NewRow();
                row["ID"] = b.ID;
                row["Type"] = b.Type;
                row["Quantity"] = b.Quantity;
                row["PricePer2Hours"] = b.CostPer2Hours;
                row["Deposit"] = b.Deposit;
                row["Capacity"] = b.Capacity;
                row["Remark"] = b.Remark;
                row["Location"] = b.Location.ID;
                row["City"] = b.Location.City;
                dt.Rows.Add(row);
            }
            return dt;
        }



        public Boat ShowBoatInfo(int id)
        {
            foreach (Boat b in ViewAllBoats())
            {
                if (b.ID == id)
                {
                    return b;

                }
            }

            return null;

        }

    }
}
