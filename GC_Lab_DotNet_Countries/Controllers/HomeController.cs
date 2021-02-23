using GC_Lab_DotNet_Countries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace GC_Lab_DotNet_Countries.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; }

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            Countries.Add(new Country(
                "Mexico",
                new string[] { "Spanish", "Nahuatl" },
                "Que pedo guey?",
                "There are many indigenous languages in Mexico, one the most popular being an Aztecan language commonly known as Nahuatl. You probably already know a couple Nahuatl words: chocolate and coyote! Some other nahuatl words that have spread across the world are: avocado, guacamole, and chili.",
                new string[] { "Red", "White", "Green" }
                ));

            Countries.Add(new Country(
                "Italy",
                new string[] { "Italian" },
                "Mi piacciono i tuoi pantaloni.",
                "There are too people named 'Antonio' in Italy.",
                new string[] { "Red", "White", "Green" }
                ));

            return View(Countries);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
