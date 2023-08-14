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
    public class ProductPageModel : PageModel
    {
        Sloepke sloepke = new Sloepke();
        
        [BindProperty]
        public Boat Boat { get; set; }
        [BindProperty(SupportsGet = true)]
        public int ID { get; set; }
        Customer Customer { get; set; }
        public void OnGet()
        {
            Boat = new Boat();
            Boat = sloepke.BoatManager.ShowBoatInfo(ID);
         

        }
       
    }
}
