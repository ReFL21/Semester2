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
    public class ProfilePageModel : PageModel
    {
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
            else
            {
                RedirectToPage("Index");
            }
        }
    }
}
