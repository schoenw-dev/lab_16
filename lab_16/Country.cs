using System;
using System.Collections.Generic;
using System.Text;

namespace lab_16
{
    public class Country
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public Country()
        {

        }

        public Country(string name, string language)
        {
            Name = name;
            Language = language;
        }

        public static List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>
            {

                new Country("United States", "English"),
                new Country("Japan", "Japanese"),
                new Country("Russia", "Russian"),
                new Country("Mexico", "Spanish"),
                new Country("Canada", "English"),
                new Country("United Kingdom", "English"),
                new Country("Spain", "Spanish"),
                new Country("Germany", "German"),

            };


            return countries;

        }

    }
}