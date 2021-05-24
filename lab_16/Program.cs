using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = Country.GetCountries();

            CountriesTextFile.CreateAndPopulateTextFile(countries);

            static List<Country> ChangeCountries(List<Country> countries1, Country country1)
            {
                List<Country> countries = countries1;
                countries.Add(country1);

                return countries;
            }

            bool repeat = true;
            while (repeat)
            {

                //List<Country> countries = Country.GetCountries();
                int userInput = CountriesApp.DisplayMenu();
                if (userInput == 1)
                {
                    CountriesApp.TxtReader(countries);
                    repeat = true;
                }
                else if (userInput == 2)
                {
                    
                    Country country = CountriesApp.AddCountry();
                    countries = ChangeCountries(countries, country);
                    CountriesTextFile.CreateAndPopulateTextFile(countries);
                    
                    repeat = true;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }

            }

        }
    }
}