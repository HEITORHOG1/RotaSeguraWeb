using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class IncomeExpenseDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "ID do Veículo")]
        public string VehicleId { get; set; }

        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        [Display(Name = "Tipo")]
        public string Type { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Valor")]
        public int Amount { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedDate { get; set; }
    }
}
