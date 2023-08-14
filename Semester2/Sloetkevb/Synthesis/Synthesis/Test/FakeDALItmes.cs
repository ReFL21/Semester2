using Synthesis.DALBoats;
using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Test
{
    public class FakeDALItmes : IItemsDAL
    {
        public int ExecutionAddCount { get; set; }
        public int ExecutionDeleteCount { get; set; }
        public int ExecutionViewAllItemsCount { get; set; }

        public void AddItem(Items item)
        {
            ExecutionAddCount++;
        }

        public void DeleteItem(Items items)
        {
            ExecutionDeleteCount++;
        }

        public List<Items> ViewAllItems()
        {
            ExecutionViewAllItemsCount++;
            List<Items> items = new List<Items>();
            return items;
        }
    }
}
