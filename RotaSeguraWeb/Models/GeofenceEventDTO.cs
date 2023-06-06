using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class GeofenceEventDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID do Veículo")]
        public string VehicleId { get; set; }

        [Display(Name = "ID da Geofence")]
        public string GeofenceId { get; set; }

        [Display(Name = "Evento")]
        public string Event { get; set; }

        [Display(Name = "Data/Hora")]
        public string Timestamp { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }
    }
}
