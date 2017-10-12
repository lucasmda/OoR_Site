﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace OoR_Site.Models
{
    public class Cliente
    {
        [Display(Name = "Nome")]
        public string nome { get; set;}
        [Display(Name = "Senha")]
        public string senha { get; set; }
        [Display(Name = "CEP")]
        public string cep { get; set; }
        [Display(Name = "Telefone")]
        public string telefone { get; set; }
        [Display(Name = "CPF")]
        public string cpf { get; set; }
        [Display(Name = "Data de Nascimento")]
        public string dataNascimento { get; set; }
        [Display(Name = "E-mail")]
        public string email { get; set; }
        [Display(Name = "Valor da Divida")]
        public double valorDivida { get; set; }
    }
}