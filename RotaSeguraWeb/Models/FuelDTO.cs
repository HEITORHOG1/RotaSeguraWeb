using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class FuelDTO
    {
        [Display(Name = "ID do Combustível")]
        public int FuelId { get; set; }

        [Display(Name = "ID do Veículo")]
        public int VehicleId { get; set; }

        [Display(Name = "Quantidade de Combustível")]
        public string FuelQuantity { get; set; }

        [Display(Name = "Leitura do Odômetro")]
        public string OdometerReading { get; set; }

        [Display(Name = "Preço do Combustível")]
        public string FuelPrice { get; set; }

        [Display(Name = "Data de Abastecimento")]
        public DateTime FuelFillDate { get; set; }

        [Display(Name = "Combustível Adicionado por")]
        public string FuelAddedBy { get; set; }

        [Display(Name = "Comentários sobre o Combustível")]
        public string FuelComments { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }
    }

}
