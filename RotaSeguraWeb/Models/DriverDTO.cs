using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using static RotaSeguraWeb.Models.Enuns.Enum;

namespace RotaSeguraWeb.Models
{
    public class DriverDTO
    {
        [Display(Name = "S.No")]
        public int DId { get; set; }

        [Display(Name = "Nome")]
        public string DName { get; set; }

        [Display(Name = "Telefone")]
        public string DMobile { get; set; }

        [Display(Name = "Endereço")]
        public string DAddress { get; set; }

        [Display(Name = "Idade")]
        public int DAge { get; set; }

        [Display(Name = "N. Da Licença")]
        public string DLicenseno { get; set; }

        [Display(Name = "Data Expiração")]
        public DateTime DLicenseExpDate { get; set; }

        [Display(Name = "Total Experiencia")]
        public int DTotalExp { get; set; }

        [Display(Name = "Data Adesão")]
        public DateTime DDoj { get; set; }
        [Display(Name = "Referencia")]
        public string DRef { get; set; }

        [Display(Name = "Ativo")]
        public DriveIsActive IsActive { get; set; }
        public string DFile { get; set; }
        public string DFile1 { get; set; }
        
        public string DCreatedBy { get; set; }
        [Display(Name = "Data Criação")]
        public DateTime DCreatedDate { get; set; }
        public DateTime DModifiedDate { get; set; }
    }
}
