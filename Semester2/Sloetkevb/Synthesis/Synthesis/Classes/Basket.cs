using SynthesisAssignment.classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synthesis.Classes
{
   public class Basket
    {
       private static Basket basket = new Basket();
        public static Basket Bascet
        {
            get { return basket; }
            set { basket = value; }

        }

        List<Boat> boats = new List<Boat>();
        List<Items> items = new List<Items>();
        public void AddItemsToBasket(Items item)
        {
            items.Add(item);
        }

        public void AddBoatToBasket(Boat boat)
        {
            boats.Add(boat);
        }


        public void ClearBasket()
        {
            boats.Clear();
            items.Clear();
        }

        public void RemoveBFromBasket(Boat boat)
        {
            boats.Remove(boat);
        }

        public void RemoveIFromBasket(Items item)
        {
            items.Remove(item);
        }

        public List<Boat> ViewAllBoats()
        {
            return boats;
        }
        public List<Items> ViewallItems()
        {
            return items;
        }
    }
}
