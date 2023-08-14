using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
    public interface ILocation
    {
        public void AddLocation(Location location);

        public List<Location> ViewAllLocations();

        public void DeleteLocation(Location location);
        public void EditLocation(int id, string name, string city, string address);
    }
}
