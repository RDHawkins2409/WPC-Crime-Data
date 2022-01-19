using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_Crime_Data
{
    internal class Location
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public Street Street { get; set; }
    }
}
