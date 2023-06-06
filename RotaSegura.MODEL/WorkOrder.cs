using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class WorkOrder
    {
        public int Id { get; set; }
        public int VehicleId { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
