using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AeronaveParticular : Aviao
    {
        public int OwnersNumber { get; set; }
        public double FreightValue { get; set; }

        public AeronaveParticular() : base()
        {
            OwnersNumber = 0;
            FreightValue = 0.0;
        }

        public AeronaveParticular( int id,string model, int capacity, int autonomy, string maintenanceDate,
                                  string activity, int engineQuantity, string brand, int manufacturingYear,
                                  int ownersNumber, double freightValue)
                                  : base(id, model, capacity, autonomy, maintenanceDate, activity, engineQuantity, brand, manufacturingYear)
        {
            OwnersNumber = ownersNumber;
            FreightValue = freightValue;
        }

        public override string ToString()
        {
            return base.ToString() + " Owners Number: " + OwnersNumber +
                   " Freight Value: " + FreightValue;
        }
    }
}
