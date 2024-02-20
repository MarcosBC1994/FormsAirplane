using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AeronaveMercadorias : Aviao
    {
        public int CargoCapacity { get; set; }
        public double FreightValue { get; set; }

        public AeronaveMercadorias() : base()
        {
            CargoCapacity = 0;
            FreightValue = 0.0;
        }

        public AeronaveMercadorias( int id,string model, int capacity, int autonomy, string maintenanceDate,
                                    string activity, int engineQuantity, string brand, int manufacturingYear,
                                    int cargoCapacity, double freightValue)
                                    : base(id,model, capacity, autonomy, maintenanceDate, activity, engineQuantity, brand, manufacturingYear)
        {
            CargoCapacity = cargoCapacity;
            FreightValue = freightValue;
        }

        public override string ToString()
        {
            return base.ToString() + " Cargo Capacity: " + CargoCapacity +
                   " Freight Value: " + FreightValue;
        }
    }
}
