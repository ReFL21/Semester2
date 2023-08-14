using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Synthesis.Classes;
using SynthesisAssignment.classes;

namespace Synthesis_Assignment.Pages
{
    public class BasketModel : PageModel
    {
       public List<Items> Items;
        public Basket basket = Basket.Bascet;
        Sloepke sloepke = new Sloepke();
       public Customer Customer { get; set; }
        public void OnGet()
        {
          
            int id = (int)HttpContext.Session.GetInt32("ID");
            if (id != -1)
            {
                foreach (People u in sloepke.PeopleManager.ViewPeople())
                {
                    if (u is Customer)
                    {
                        if (u.ID == id)
                        {
                            Customer = (Customer)u;

                        }
                    }
                   
                }
            }
            Items = basket.ViewallItems();
        }


        public IActionResult OnGetAddItemsToBasket(int id)
        {
            int pid = (int)HttpContext.Session.GetInt32("ID");
            if (pid != -1)
            {
                foreach (People u in sloepke.PeopleManager.ViewPeople())
                {
                    if (u is Customer)
                    {
                        if (u.ID == pid)
                        {
                            Customer = (Customer)u;
                            foreach (Items item in sloepke.ItemsManger.ViewAllItmes())
                            {
                                if (item.ID == id)
                                {
                                    basket.AddItemsToBasket(item);
                                }
                            }
                        }
                    }

                }
            }
            return RedirectToPage("Renting Page");
        }


        public IActionResult OnGetAddBoatToBasket(int id)
        {
            int pid = (int)HttpContext.Session.GetInt32("ID");
            if (pid != -1)
            {
                foreach (People u in sloepke.PeopleManager.ViewPeople())
                {
                    if (u is Customer)
                    {
                        if (u.ID == pid)
                        {
                            Customer = (Customer)u;
                            foreach (Boat item in sloepke.BoatManager.ViewAllBoats())
                            {
                                if (item.ID == id)
                                {
                                    basket.AddBoatToBasket(item);
                                }
                            }
                        }
                    }

                }
            }
            return RedirectToPage("Renting Page");
        }

        public IActionResult OnGetRemoveBfromBasket(int id)
        {
            foreach (Boat item in basket.ViewAllBoats().ToList())
            {
                if (item.ID == id)
                {
                    basket.RemoveBFromBasket(item);
                }
            }
            return RedirectToPage("Basket");

        }

        public IActionResult OnGetRemoveIfromBasket(int id)
        {
            foreach (Items item in basket.ViewallItems().ToList())
            {
                if (item.ID == id)
                {
                    basket.RemoveIFromBasket(item);
                }
            }
            return RedirectToPage("Basket");

        }


        public void OnPost()
        {
            
         Rent rent = sloepke.RentManager.ViewRents().Last();
            foreach (Items i in basket.ViewallItems())
            {
                rent.Items.Add(i);
            }
            foreach (Boat item in basket.ViewAllBoats())
            {
                rent.Boats.Add(item);
            }
            //int bdeposit=0;
            //for (int i = 0; i < rent.Boats.Count; i++)
            //{

            //    bdeposit += rent.Boats[i].Deposit;

            //}
            //int ideposit = 0;
            //for (int i = 0; i < rent.Items.Count; i++)
            //{
            //    ideposit += rent.Items[i].Deposit;
            //}
            // sloepke.RentManager.AddBoatsToRent(new RentedProducts());
            foreach (Boat item in rent.Boats)
            {
                sloepke.RentManager.AddBoatsToRent(new RentedProduct(rent, item,1,item.Deposit));
            }
            foreach (Items item in rent.Items)
            {
                sloepke.RentManager.AddItemsToRent(new RentedProduct(rent, item, 1, item.Deposit));
            }
           
        }


    }
}
