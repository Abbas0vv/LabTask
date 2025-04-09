using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLab.Models
{
    public class Country
    {
        static int _id;
        public Country(string countryName, decimal area, string anthem, Region? countryRegion)
        {
            Id = _id;
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            CountryRegion = countryRegion;
            _id++;
        }

        public int Id { get; set; }
        public string CountryName { get; set; }
        public decimal Area { get; set; }
        public string Anthem { get; set; }

        public Region? CountryRegion { get; set; }
    }
}
