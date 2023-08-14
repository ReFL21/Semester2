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
    public class Update_RentModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        int RentID { get; set; }
        Sloepke sloepke = new Sloepke();
        [BindProperty]
       public Rent Rent { get; set; }
        public Customer Customer { get; set; }
        public List<Location> Locations { get; set; }
        public void OnGet()
        {
            Locations = sloepke.LocationManager.ViewAllLocations();

        }
        public void OnPost()
        {
            int id = (int)HttpContext.Session.GetInt32("ID");
            if (id!=-1)
            {
                foreach (People u in sloepke.PeopleManager.ViewPeople())
                {
                    if (u is Customer)
                    {
                        if (u.ID == id)
                        {
                            Customer = (Customer)u;
                            foreach (Location item in sloepke.LocationManager.ViewAllLocations())
                            {
                                if (item.ID == Rent.Location.ID)
                                {
                                    sloepke.RentManager.UpdateRent(RentID, DateTime.Now, Rent.StartingDate, Rent.EndDate, item);
                                }
                            }
                           
                        }
                    }
                }
            }
            
        }

    }
}
