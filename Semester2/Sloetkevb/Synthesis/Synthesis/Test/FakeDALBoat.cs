using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
   public class FakeDALBoat : IBoatDAL
    {
        public int ExecutionAddCount { get; set; }
        public int ExecutionDeleteCount { get; set; }
        public int ExecutionsubtractCount { get; set; }
        public int ExecutionAddQCount { get; set; }
        public int ExecutionViewAllBoatsCount { get; set; }

        public void AddBoat(Boat boat)
        {
            ExecutionAddCount++;
        }
        public void DeleteBoat(Boat boat)
        {
            ExecutionDeleteCount++;
        }
        public void SubtractQuantity(Boat boat)
        {
            ExecutionsubtractCount++;
        }
        public void AddQuantity(Boat boat)
        {
            ExecutionAddQCount++;
        }
        public List<Boat> ViewAllBoats()
        {
            ExecutionViewAllBoatsCount++;
            List < Boat > boats = new List<Boat>();
            return boats;
        } 
    }
}
