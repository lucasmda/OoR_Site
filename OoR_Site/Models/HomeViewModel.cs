using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OoR_Site.Models
{
    public class HomeViewModel
    {
        public Noticia noticia { get; set; }
        public Usuario usuario { get; set;}
        public OpcoesInvestimento opcao { get; set; }
        public IEnumerable<Noticia> noticias { get; set; }
        public IEnumerable<Produto> produtos { get; set; }  
        public IEnumerable<OpcoesInvestimento> opcoes { get; set; }      
    }
}