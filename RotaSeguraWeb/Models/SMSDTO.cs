using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class SMSDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Número de Telefone")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Mensagem")]
        public string Message { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }
    }
}
