using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class WorkOrderDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID do Veículo")]
        public int VehicleId { get; set; }

        [Display(Name = "Tipo")]
        public string Type { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Data de Abertura")]
        public DateTime OpenDate { get; set; }

        [Display(Name = "Data de Encerramento")]
        public DateTime CloseDate { get; set; }

        [Display(Name = "Observações")]
        public string Notes { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }
    }
}
