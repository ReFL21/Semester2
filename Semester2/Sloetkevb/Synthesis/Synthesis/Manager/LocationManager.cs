using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using SynthesisAssignment.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SynthesisAssignment.Manager
{
    public class LocationManager
    {
        ILocation location;
        public LocationManager(ILocation location)
        {
            this.location = location;
        }

        public LocationManager()
        {
        }

        public void AddLocation(Location locations)
        {
            location.AddLocation(locations);
        }

        public void DeleteLocation(Location locations)
        {
            location.DeleteLocation(locations);
        }

        public List<Location> ViewAllLocations()
        {
            List<Location> locations = location.ViewAllLocations();
            return locations;
        }
        public void EditLocation(int id, string name, string city, string address)
        {
            location.EditLocation(id, name, city, address);
        }

        public DataTable ViewLocations()
        {
            location.ViewAllLocations();
            var dt = new DataTable();
            dt.Columns.Add(new DataColumn(("ID"), typeof(int)));
            dt.Columns.Add(new DataColumn(("Name"), typeof(string)));
            dt.Columns.Add(new DataColumn(("City"), typeof(string)));
            dt.Columns.Add(new DataColumn(("Address"), typeof(string)));
            foreach (Location l in location.ViewAllLocations())
            {
                var row = dt.NewRow();
                row["ID"] = l.ID;
                row["Name"] = l.Name;
                row["City"] = l.City;
                row["Address"] = l.Address;
                dt.Rows.Add(row);
            }
            return dt;

        }
    }
}
