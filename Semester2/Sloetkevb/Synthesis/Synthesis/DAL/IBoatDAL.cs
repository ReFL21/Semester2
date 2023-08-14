using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
   public interface IBoatDAL
    {
        public void AddBoat(Boat boat);

        public List<Boat> ViewAllBoats();

        public void DeleteBoat(Boat boat);
        public void SubtractQuantity(Boat boat);
        public void AddQuantity(Boat boat);

    }
}
