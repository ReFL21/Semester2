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
    public class LoginModel : PageModel
    {
        Sloepke sloepke = new Sloepke();
        [BindProperty]
       public Customer Customer { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost(string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                int id = sloepke.PeopleManager.CheckUser(Customer.Username, Customer.Password);
                
                if (id != -1)
                {
                    People customer = sloepke.PeopleManager.GetUser(id);
                    HttpContext.Session.SetInt32("ID", customer.ID);
                }
                if (!String.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    return RedirectToPage("Index");
                }

            }
            else
            {
                ModelState.AddModelError("InvalidCredentials", "The supplied username and/or password is invalid");
                return Page();
            }

        }
    }
}
