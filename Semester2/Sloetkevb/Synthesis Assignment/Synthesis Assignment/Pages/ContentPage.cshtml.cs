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
    public class ContentPageModel : PageModel
    {
        Sloepke sloepke = new Sloepke();
        Boat Boat { get; set; }
        public IEnumerable<Boat> Boats { get; set; }
        public void OnGet()
        {
            Boats = sloepke.BoatManager.ViewAllBoats();
        }






    }
}
