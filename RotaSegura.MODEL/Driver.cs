using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class Driver
    {
        public int DId { get; set; }
        public string DName { get; set; }
        public string DMobile { get; set; }
        public string DAddress { get; set; }
        public int DAge { get; set; }
        public string DLicenseno { get; set; }
        public DateTime DLicenseExpDate { get; set; }
        public int DTotalExp { get; set; }
        public DateTime DDoj { get; set; }
        public string DRef { get; set; }
        public int DIsActive { get; set; }
        public string DFile { get; set; }
        public string DFile1 { get; set; }
        public string DCreatedBy { get; set; }
        public DateTime DCreatedDate { get; set; }
        public DateTime DModifiedDate { get; set; }
    }

}
