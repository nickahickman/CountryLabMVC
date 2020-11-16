using CountriesLabMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CountriesLabMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public List<Country> Countries = new List<Country>
        {
            new Country("USA", new string [] { "Murican" }, "USA! USA! USA! USA!", "USA Freedom #1", new string[] { "#b22234", "#fff", "#3c3b6e" }, "~/img/usaFlag.png"),
            new Country("Mexico", new string [] { "Spanish" }, "Hola Mundo!", "Home of the best food", new string[] { "#ce1126", "#fff", "#006847" }, "~/img/mexicoFlag.png"),
            new Country("Japan", new string [] { "Japanese" }, "Kon'nichiwa sekai", "Nintendo's Homeland", new string[] { "#be0029", "#fff" }, "~/img/japanFlag.png"),
            new Country("Egypt", new string [] { "Arabic" }, "Marhabaan bialealam", "Walk like them", new string[] { "#ce1126", "#fff", "#000" }, "~/img/egyptFlag.png"),
            new Country("Algeria", new string [] { "Arabic and Berber" }, "Marhabaan bialealam", "Describe Algeria in a sentence", new string[] { "#007a33", "#fff", "#c8102e" }, "~/img/algeriaFlag.png"),
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Countries);
        }

        [HttpPost]
        public IActionResult DisplayCountry(Country c)
        {

            return View();
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
