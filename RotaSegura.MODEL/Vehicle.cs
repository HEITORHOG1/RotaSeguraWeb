using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class Vehicle
    {
        public int VId { get; set; }
        public string VRegistrationNo { get; set; }
        public string VName { get; set; }
        public string VModel { get; set; }
        public string VChassisNo { get; set; }
        public string VEngineNo { get; set; }
        public string VManufacturedBy { get; set; }
        public string VType { get; set; }
        public string VColor { get; set; }
        public string VMileagePerLitre { get; set; }
        public int VIsActive { get; set; }
        public int VGroup { get; set; }
        public string VRegExpDate { get; set; }
        public string VApiUrl { get; set; }
        public string VApiUsername { get; set; }
        public string VApiPassword { get; set; }
        public string VCreatedBy { get; set; }
        public DateTime VCreatedDate { get; set; }
        public DateTime VModifiedDate { get; set; }
    }
}
