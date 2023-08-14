using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuelSysClassLibrary;
using DuelSysClassLibrary.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DuelSysWebsite.Pages
{
    public class TournamentPageModel : PageModel
    {
        DuelSysInc duelSys = new DuelSysInc();
        public People People { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }
        public Tournament Tournament { get; set; }
        public void OnGet()
        {
            Tournament = new Tournament();
            Tournament = duelSys.TournamentManager.GetTournament(ID);
        }


        public void OnPost()
        {
            Tournament = new Tournament();
            Tournament = duelSys.TournamentManager.GetTournament(ID);

            var difference = (Tournament.Startdate - DateTime.Now).TotalDays;
            var weeks = (int)difference / 7;
            if (weeks >= 1)
            {
                int id = (int)HttpContext.Session.GetInt32("ID");
                if (id != -1)
                {
                    People = duelSys.PeopleManager.GetPerson(id);
                    if (People is Player)
                    {
                        duelSys.PeopleManager.RegisterForTournament((Player)People, Tournament);
                    }
                    else
                    {
                        RedirectToPage("Index");
                    }
                }
                else
                {
                    RedirectToPage("Index");
                }
            }
        }
    }
}
