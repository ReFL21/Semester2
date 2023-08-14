using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Synthesis.Classes;
using SynthesisAssignment.classes;

namespace Synthesis_Assignment.Pages
{
    public class RegisterModel : PageModel
    {
        Sloepke sloepke = new Sloepke();

        [BindProperty]
       public Customer Customer { get; set; }


        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                sloepke.PeopleManager.AddPeople(Customer);
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage("Register");
            }
       
        
        
        }


    }
}
