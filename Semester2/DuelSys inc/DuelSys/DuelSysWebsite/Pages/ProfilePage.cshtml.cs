using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysClassLibrary.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmartphoneSite.Pages
{
    public class ProfilePageModel : PageModel
    {
        DuelSysInc duelSys = new DuelSysInc();
       public People User { get; set; }

        public void OnGet()
        {
            int id = (int)HttpContext.Session.GetInt32("ID");
            if (id != -1)
            {
               User= duelSys.PeopleManager.GetPerson(id);
            }
            else
            {
                RedirectToPage("Index");
            }
        }
    }
}
