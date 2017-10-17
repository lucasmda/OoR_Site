using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OoR_Site.Models
{
    public class Contato
    {
        public int Id { get; set; }
        [Display(Name ="Nome")]
        public string nome { get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }
        [Display(Name = "Telefone")]
        public string telefone { get; set; }

        public IEnumerable<Contato> contatos { get; set; }
    }
}