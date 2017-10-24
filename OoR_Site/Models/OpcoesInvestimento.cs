using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OoR_Site.Models
{
    public class OpcoesInvestimento
    {
        public int Id { get; set; }
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        [Display(Name = "Valor")]
        public float valor { get; set; }
        [Display(Name = "Quantidade")]
        public int quantidade { get; set; }
    }
}