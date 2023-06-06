using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class Maintenance
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID do Veículo")]
        public int VehicleId { get; set; }

        [Display(Name = "Tipo de Serviço")]
        public string ServiceType { get; set; }

        [Display(Name = "Data do Serviço")]
        public DateTime ServiceDate { get; set; }

        [Display(Name = "Leitura do Odômetro")]
        public int OdometerReading { get; set; }

        [Display(Name = "Notas de Serviço")]
        public string ServiceNotes { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedDate { get; set; }
    }
}
