using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RotaSeguraWeb.Models
{
    public class LoginDTO
    {
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Display(Name = "Nome de Usuário")]
        public string Username { get; set; }

        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Tipo de Usuário")]
        public string UserType { get; set; }

        [Display(Name = "Ativo")]
        public bool IsActive { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Data de Modificação")]
        public DateTime ModifiedDate { get; set; }
    }
}