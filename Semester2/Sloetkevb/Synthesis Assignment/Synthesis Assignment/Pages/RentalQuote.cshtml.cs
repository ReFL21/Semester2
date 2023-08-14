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
    public class RentalQuoteModel : PageModel
    {
        List<Boat> rentedBoats = new List<Boat>();
        public RentedProduct RentedProducts { get; set; }
        List<Rent> rents = new List<Rent>();
        public Sloepke sloepke = new Sloepke();
        public Customer Customer { get; set; }
        public Rent Rent { get; set; }

        public int Total { get; set; }
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
                            foreach (Rent item in sloepke.RentManager.ViewRents())
                            {
                                if (item.Person.ID == u.ID)
                                {
                                    rents.Add(item);
                                }
                            }
                            Rent = rents.Last();
                            List<RentedProduct> rentedBoats = sloepke.RentManager.ViewRentedBoats(Rent);
                            List<RentedProduct> rentedItems = sloepke.RentManager.ViewRentedItems(Rent);
                            Total = rentedBoats.Sum(i => i.Quantity * i.TotalPrice) + rentedItems.Sum(i => i.TotalPrice * i.Quantity);
                        }
                    }
                }
            }
        }


        public void OnPost()
        {
            RedirectToPage("Index");
        
        }



    }
}
