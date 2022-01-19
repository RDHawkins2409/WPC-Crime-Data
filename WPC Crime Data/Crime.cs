using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC_Crime_Data
{
    internal class Crime
    {
        public string Category { get; set; }
        public string Location_Type { get; set; }
        public Location Location { get; set; }
        public string Context { get; set; }
        public string Persistent_ID { get; set; }
        public int ID { get; set; }
        public string Location_Subtype { get; set; }
        public string Month { get; set; }
        public Outcome Outcome_Status { get; set; }
    }
}
