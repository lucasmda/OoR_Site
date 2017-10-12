using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OoR_Site.Models
{
    public class Produto
    {
        public int id { get; set; }
        [Display(Name = "Produto")]
        public string produto { get; set; }
    }
}