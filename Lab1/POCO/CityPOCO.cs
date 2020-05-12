using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab1.POCO
{
    public class CityPOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Country_Id { get; set; }

        public string Country { get; set; }
    }
}