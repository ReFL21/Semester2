using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
    public class FakeLocationDAL : ILocation
    {
        public int ExecutionAddCount { get; set; }
        public int ExecutionDeleteCount { get; set; }
        public int ExecutionEditCount { get; set; }
        public int ExecutionViewAllLocationCount { get; set; }
        public void AddLocation(Location location)
        {
            ExecutionAddCount++;
        }

        public void DeleteLocation(Location location)
        {
            ExecutionDeleteCount++;
        }

        public void EditLocation(int id, string name, string city, string address)
        {
            ExecutionEditCount++;
        }

        public List<Location> ViewAllLocations()
        {
            ExecutionViewAllLocationCount++;
            List<Location> locations = new List<Location>();
            return locations;

        }
    }
}
