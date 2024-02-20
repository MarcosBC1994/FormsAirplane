using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AeronaveComercial : Aviao
    {
        public int DailyFlightsNumber { get; set; }
        public string Airline { get; set; }

        public AeronaveComercial() : base()
        {
            DailyFlightsNumber = 0;
            Airline = "ND";
        }

        public AeronaveComercial( int id,string model, int capacity, int autonomy, string maintenanceDate,
                                  string activity, int engineQuantity, string brand, int manufacturingYear,
                                  int dailyFlightsNumber, string airline)
                                  : base(id,model, capacity, autonomy, maintenanceDate, activity, engineQuantity, brand, manufacturingYear)
        {
            DailyFlightsNumber = dailyFlightsNumber;
            Airline = airline;
        }

        public override string ToString()
        {
            return base.ToString() + " Daily Flights Number: " + DailyFlightsNumber +
                   " Airline: " + Airline;
        }
    }
}
