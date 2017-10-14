using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OoR_Site.Models
{
    public class Noticia
    {
        public int Id { get; set; }
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        [Display(Name = "Usuario")]
        public int id_usuario { get; set; }
        [Display(Name = "Produto")]
        public int id_produto { get; set; }
        [Display(Name = "Usuario")]
        public Usuario Usuario;
        [Display(Name = "Produto")]
        public Produto Produto;
    }
}