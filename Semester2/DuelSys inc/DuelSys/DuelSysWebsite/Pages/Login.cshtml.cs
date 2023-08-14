using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DuelSysClassLibrary.Classes;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartphoneSite.Pages
{
    public class LoginModel : PageModel
    {

        public DuelSysInc duelsys = new DuelSysInc();
        [BindProperty]
        public Login MyUser { get; set; }
        
        public void OnGet()
        {
        }
        public IActionResult OnPost(string? returnUrl)
        {
            if (ModelState.IsValid)
            {
                int id = duelsys.PeopleManager.CheckUser(MyUser.Username, MyUser.Password);
                if (id != -1)
                {

                    People user = duelsys.PeopleManager.GetPerson(id);
                    HttpContext.Session.SetInt32("ID", user.ID);


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
