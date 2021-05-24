using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_16
{
    public class CountriesTextFile : Country
    {
        public static void CreateAndPopulateTextFile(List<Country> countries)
        {
            //List<Country> countries = Country.GetCountries();

            StreamWriter writer = new StreamWriter("../../../countries.txt");
            foreach (Country country in countries)
            {
                writer.WriteLine($"{country.Name} | {country.Language}");
            }
            writer.Close();



        }
    }
}