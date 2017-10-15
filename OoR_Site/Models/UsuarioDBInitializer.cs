using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_Site.Context;
using OoR_Site.Models;

namespace OoR_Site.Models
{
    public class UsuarioDBInitializer : DropCreateDatabaseAlways<Context.Context>
    {
        protected override void Seed(Context.Context context)
        {
            context.usuarios.Add(new Usuario()
            {
                nome = "Lucas Modesto",
                senha = "mudar@123",
                cep = "098.23.456",
                telefone = "4377-5212",
                cpf = "234.432.345-1",
                dataNascimento = "27/06/2997",
                email = "lucasmda27@gmail.com",
                usuario = "lucasmda"
            });
            context.usuarios.Add(new Usuario()
            {
                nome = "Ivo Mancinelli",
                senha = "123@mudar",
                cep = "043.24.423",
                telefone = "4388-5234",
                cpf = "124.322.455-2",
                dataNascimento = "30/04/1990",
                email = "ivo.mancinelli@gmail.com",
                usuario = "ivom"
            });
            context.usuarios.Add(new Usuario()
            {
                nome = "Natalia Moura",
                senha = "@mudar123",
                cep = "567.33.098",
                telefone = "2388-0912",
                cpf = "342.563.213-23",
                dataNascimento = "24/09/1986",
                email = "natalia.moura@gmail.com",
                usuario = "nataliamsf"
            });

            base.Seed(context);
        }
    }
}