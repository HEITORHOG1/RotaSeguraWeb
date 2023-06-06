using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class Geofence
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Area { get; set; }
        public string Vehicles { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
