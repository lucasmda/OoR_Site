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
        [Display(Name = "Titulo")]
        public string titulo { get; set; }
        [Display(Name = "Descricao")]
        public string descricao { get; set; }
        [Display(Name = "Usuario")]
        public int UsuarioId { get; set; }
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        [Display(Name = "Usuario")]
        public virtual Usuario Usuario { get; set; }
        [Display(Name = "Produto")]
        public virtual Produto Produto { get; set; }
    }
}