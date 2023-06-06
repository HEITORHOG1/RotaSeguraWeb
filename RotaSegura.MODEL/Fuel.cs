using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class Fuel
    {
        public int FuelId { get; set; }
        public int VehicleId { get; set; }
        public string FuelQuantity { get; set; }
        public string OdometerReading { get; set; }
        public string FuelPrice { get; set; }
        public DateTime FuelFillDate { get; set; }
        public string FuelAddedBy { get; set; }
        public string FuelComments { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
