using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysClassLibrary.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartphoneSite.Pages
{
    public class RegisterModel : PageModel
    {
        public string message;
        DuelSysInc duelSys = new DuelSysInc();
        [BindProperty]
       public Player User { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
              
                    if (duelSys.PeopleManager.IsTaken(User.Username) == -1)
                    {
                        message = "This Username exists.Please try again!";
                }
                else
                {
                    duelSys.PeopleManager.Register(User);
                }
                
            }
        
        
        
        }
    }
}
