using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Models
{
    public class Planet
    {
        public string Name { get; set; }
        public decimal Area { get; set; }
        List<Country> Countries;

        public Planet(string name, decimal area)
        {
            Name = name;
            Area = area;
        }

        public void CreateAndAddCountry()
        {
            Console.WriteLine("Enter new country name");
            string countryName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter new country area");
            decimal area = 0;
            while (!decimal.TryParse(Console.ReadLine(), out area))
            {
                Console.WriteLine("Enter correctly!");
            }
            Console.WriteLine();
            Console.WriteLine("Enter new country anthem");
            string anthem = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter new country region code");
            int regionCode = 0;
            while (!int.TryParse(Console.ReadLine(), out regionCode))
            {
                Console.WriteLine("Enter correctly");
            }
            Region? regionName;
            switch (regionCode)
            {
                case 1:
                    regionName = Region.Europe;
                    break;
                case 2:
                    regionName = Region.Asia;
                    break;
                default:
                    regionName = null;
                    break;
            }

            Country country = new Country(countryName, area, anthem, regionName);
            Console.WriteLine("Country created");
            Console.WriteLine();
            Countries.Add(country);
            Console.WriteLine("Added");
        }
        public void UpdateCountry(int id, Country country)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].Id == id)
                    Countries[i] = country;
            }
            Console.WriteLine("Updated");
        }
        public void RemoveCountry(int id, Country country)
        {
            Countries.RemoveAt(id);
            Console.WriteLine("Country removed");
        }
        public List<Country> GetAllCountries()
        {
            Console.WriteLine("All Done!");
            return Countries;
        }
        public List<Country> GetCountryByRegion(Region? region)
        {
            List<Country> foundednCountries = new List<Country>();
            for (int i = 0; i < Countries.Count; i++)
            {
                if (Countries[i].CountryRegion == region)
                    foundednCountries.Add(Countries[i]);
            }
            Console.WriteLine("All Done!");
            return foundednCountries;
        }
    }
}
