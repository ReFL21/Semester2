using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Synthesis.Classes;
using SynthesisAssignment.classes;

namespace Synthesis_Assignment.Pages
{
    public class Renting_PageModel : PageModel
    {
        [BindProperty]
       public Location Location { get; set; }
        Customer Customer { get; set; }
       public Sloepke sloepke = new Sloepke();
        [BindProperty]
       public Rent Rent { get; set; }
       public List<Location> Locations { get; set; }
        public IEnumerable<Boat> Boats { get; set; }
        public IEnumerable<Items> Items { get; set; }
        string message;
        List<Location> selectedlocation = new List<Location>();
        
        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Rent.StartingDate > Rent.EndDate && Rent.StartingDate < DateTime.Now)
                {
                    message = "Please fill correct information!";
                }
                else
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
                                    foreach (Location item in sloepke.LocationManager.ViewAllLocations())
                                    {
                                        if (item.ID == Rent.Location.ID)
                                        {
                                            Rent rent = new Rent(DateTime.Now, Rent.StartingDate, Rent.EndDate, u, Rent.Note, item);
                                            sloepke.RentManager.AddRent(rent);
                                        }
                                    }
                                }
                            }
                           
                        }
                    }
                    RedirectToPage("Basket");
                }
            }
            


        }

        
        
    }
}
