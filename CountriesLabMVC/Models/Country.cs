using System;
using System.Collections.Generic;
using System.Linq;
using LiteDB;
using System.Threading.Tasks;

namespace CountriesLabMVC.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string[] OfficialLanguages { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public string[] NationalColors { get; set; }

        public string FlagURL { get; set; }

        public Country() { }

        public Country(string name, string[] languages, string greeting, string description, string[] colors, string flagURL)
        {
            Name = name;
            OfficialLanguages = languages;
            Greeting = greeting;
            Description = description;
            NationalColors = colors;
            FlagURL = flagURL;
        }
    }
}
