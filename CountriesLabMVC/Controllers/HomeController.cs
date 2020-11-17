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
            new Country("USA", "Murican", "USA! USA! USA! USA!", "USA Freedom #1", new string[] { "Red", "White", "Blue" }, "/img/usaFlag.png"),
            new Country("Mexico", "Spanish", "Hola Mundo!", "Home of the best food", new string[] { "Green", "White", "Red" }, "/img/mexicoFlag.png"),
            new Country("Japan", "Japanese", "Kon'nichiwa sekai", "Nintendo's Homeland", new string[] { "Red", "White" }, "/img/japanFlag.png"),
            new Country("Egypt", "Arabic", "Marhabaan bialealam", "Walk like them", new string[] { "Red", "White", "Black" }, "/img/egyptFlag.png"),
            new Country("Algeria", "Arabic and Berber", "Marhabaan bialealam", "Describe Algeria in a sentence", new string[] { "Green", "White", "Red" }, "/img/algeriaFlag.png"),
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(Countries);
        }

        public IActionResult Details(string CountryName)
        {
            Country selected = Countries.Find(c => c.Name == CountryName);
            ViewData["Name"] = selected.Name;
            ViewData["Language"] = selected.OfficialLanguages;
            ViewData["Greeting"] = selected.Greeting;
            ViewData["Colors"] = String.Join(", ", selected.NationalColors);
            ViewData["Flag"] = selected.FlagURL;
            ViewData["Description"] = selected.Description;
            return View();
        }

        public IActionResult Description(string CountryDescription)
        {
            ViewData["Description"] = CountryDescription;
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
