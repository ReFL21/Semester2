using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.DALBoats
{
    public interface IItemsDAL
    {
        public void AddItem(Items item);

        public List<Items> ViewAllItems();

        public void DeleteItem(Items items);

    }
}
