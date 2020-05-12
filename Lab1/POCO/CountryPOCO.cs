using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.POCO
{
    public class CountryPOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<CityPOCO> Cities { get; set; }
    }
}