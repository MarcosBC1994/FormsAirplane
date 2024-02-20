using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Aeroporto
    {
        public string Location { get; set; }
        public int RunwaysNumber { get; set; }
        public int ServiceCapacity { get; set; }

        public Aeroporto()
        {
            Location = "ND";
            RunwaysNumber = 0;
            ServiceCapacity = 0;
        }

        public Aeroporto(string location, int runwaysNumber, int serviceCapacity)
        {
            Location = location;
            RunwaysNumber = runwaysNumber;
            ServiceCapacity = serviceCapacity;
        }

        public override string ToString()
        {
            return "Location: " + Location + " Runways Number: " + RunwaysNumber +
                   " Service Capacity: " + ServiceCapacity;
        }
    }
}
