using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class Maintenance
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string ServiceType { get; set; }
        public DateTime ServiceDate { get; set; }
        public int OdometerReading { get; set; }
        public string ServiceNotes { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
