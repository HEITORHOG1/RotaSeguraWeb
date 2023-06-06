using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotaSegura.MODEL
{
    public class SMS
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
