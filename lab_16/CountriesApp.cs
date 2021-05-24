using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab_16
{
    public class CountriesApp : Country
    {

        public static int DisplayMenu()
        {
            bool repeat = true;
            int outPut = -1;
            while (repeat)
            {
                Console.WriteLine("Please select from the following menu by entering the associated number:");
                Console.WriteLine("\n1. View our current list of countries.");
                Console.WriteLine("2. Add a country to our current list.");
                Console.WriteLine("3. Close application");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    outPut = 1;
                    repeat = false;
                }
                else if (userInput == "2")
                {
                    outPut = 2;
                    repeat = false;
                }
                else if (userInput == "3")
                {
                    outPut = 3;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Error! Please enter one of the following: 1, 2, or 3");
                    repeat = true;
                }


            }
            return outPut;

        }


        public static void TxtReader(List<Country> countries)
        {
            // List<Country> countries = new List<Country>();

            StreamReader reader = new StreamReader("../../../Countries.txt");
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] countryProperties = line.Split('|');
                countries.Add(new Country(countryProperties[0], countryProperties[1]));

                line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
        }

        public static Country AddCountry()
        {
            Country userCountry = new Country();
            Console.WriteLine("\nEnter name of country:");
            userCountry.Name = Console.ReadLine();

            Console.WriteLine("\nEnter your country's official language:");
            userCountry.Language = Console.ReadLine();

            return userCountry;

        }
    }
}