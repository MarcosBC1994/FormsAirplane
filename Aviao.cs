using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Aviao
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public int Autonomy { get; set; }
        public string MaintenanceDate { get; set; }
        public string Activity { get; set; }
        public int EngineQuantity { get; set; }
        public string Brand { get; set; }
        public int ManufacturingYear { get; set; }

        public Aviao()
        { 
            Id = 0;
            Model = "ND";
            Capacity = 0;
            Autonomy = 0;
            MaintenanceDate = "0";
            Activity = "ND";
            EngineQuantity = 0;
            Brand = "ND";
            ManufacturingYear = 0;
        }

        public Aviao( int id, string model, int capacity, int autonomy, string maintenanceDate, string activity, int engineQuantity, string brand, int manufacturingYear)
        {
            Id = id;
            Model = model;
            Capacity = capacity;
            Autonomy = autonomy;
            MaintenanceDate = maintenanceDate;
            Activity = activity;
            EngineQuantity = engineQuantity;
            Brand = brand;
            ManufacturingYear = manufacturingYear;
        }

        public override string ToString()
        {
            return "ID: " + Id + "Model: " + Model + " Capacity: " + Capacity + " Autonomy: " + Autonomy +
                   " Maintenance Date: " + MaintenanceDate + " Activity: " + Activity +
                   " Engine Quantity: " + EngineQuantity + " Brand: " + Brand +
                   " Manufacturing Year: " + ManufacturingYear;
        }
    }

}
