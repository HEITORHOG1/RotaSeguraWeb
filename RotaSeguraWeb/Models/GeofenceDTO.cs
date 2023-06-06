using System.ComponentModel.DataAnnotations;

namespace RotaSeguraWeb.Models
{
    public class GeofenceDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Display(Name = "Área")]
        public string Area { get; set; }

        [Display(Name = "Veículos")]
        public string Vehicles { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedDate { get; set; }
    }
}
