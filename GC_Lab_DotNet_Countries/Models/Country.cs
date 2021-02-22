using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace GC_Lab_DotNet_Countries.Models
{
    public class Country
    {
        public Country(string name, string[] languages, string greeting, string description, string[] colors)
        {
            Name = name;
            Languages = languages;
            Greeting = greeting;
            Description = description;
            Colors = colors;
        }

        public Country()
        {

        }

        public string Name { get; set; }
        public string[] Languages { get; set; }
        public string Greeting { get; set; }
        public string Description { get; set; }
        public string[] Colors { get; set; }
    }
}
