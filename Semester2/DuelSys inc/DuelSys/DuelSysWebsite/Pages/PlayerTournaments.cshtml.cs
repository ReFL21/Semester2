using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysClassLibrary.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
    public class PlayerTournamentsModel : PageModel
    {

        public DuelSysInc duelSys = new DuelSysInc();
        public void OnGet()
        {
        }
    }
}
