using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class EmailTemplateDTO
    {
        [Display(Name = "S.No")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Assunto")]
        public string Subject { get; set; }

        [Display(Name = "Corpo")]
        public string Body { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }
    }
}
