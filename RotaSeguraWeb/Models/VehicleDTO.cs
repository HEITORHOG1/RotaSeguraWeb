using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static RotaSeguraWeb.Models.Enuns.Enum;

namespace RotaSeguraWeb.Models
{
    public class VehicleDTO
    {
        [Display(Name = "S.No")]
        public int VId { get; set; }

        [Display(Name = "Numero Registro")]
        public string VRegistrationNo { get; set; }

        [Display(Name = "Nome Veiculo")]
        public string VName { get; set; }

        [Display(Name = "Modelo")]
        public string VModel { get; set; }

        [Display(Name = "Numero Chassis")]
        public string VChassisNo { get; set; }

        [Display(Name = "Numero Motor")]
        public string VEngineNo { get; set; }

        [Display(Name = "Manu Faturado por")]
        public string VManufacturedBy { get; set; }

        [Display(Name = "Tipo")]
        public string VType { get; set; }

        [Display(Name = "Cor")]
        public string VColor { get; set; }

        [Display(Name = "Quilometragem por Litro")]
        public string VMileagePerLitre { get; set; }

        [Display(Name = "Ativo")]
        public VehicleIsActive VIsActive { get; set; }

        [Display(Name = "Grupo")]
        public int VGroup { get; set; }

        [Display(Name = "Tipo Veiculo")]
        public IEnumerable<SelectListItem> VTypes { get; set; }

        [Display(Name = "Grupo Veiculo")]
        public IEnumerable<SelectListItem> VGroups { get; set; }

        public string VRegExpDate { get; set; }

        [Display(Name = "API URL")]
        public string VApiUrl { get; set; }

        [Display(Name = "GPS API Nome")]
        public string VApiUsername { get; set; }

        [Display(Name = "GPS API Senha")]
        public string VApiPassword { get; set; }

        public string VCreatedBy { get; set; }

        [Display(Name = "Data Criação")]
        public DateTime VCreatedDate { get; set; }

        [Display(Name = "Data Modificação")]
        public DateTime VModifiedDate { get; set; }
    }

}
