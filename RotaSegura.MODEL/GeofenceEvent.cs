using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class GeofenceEvent
    {
        public int Id { get; set; }
        public string VehicleId { get; set; }
        public string GeofenceId { get; set; }
        public string Event { get; set; }
        public string Timestamp { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
