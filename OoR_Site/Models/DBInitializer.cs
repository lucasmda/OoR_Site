﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_Site.Context;
using OoR_Site.Models;

namespace OoR_Site.Models
{
    public class DBInitializer : DropCreateDatabaseAlways<Context.Context>
    {
        protected override void Seed(Context.Context context)
        {
            context.clientes.Add(new Cliente()
            {
                Id = 1,
                nome = "Lucas Modesto",
                senha = "mudar@123",
                cep = "098.23.456",
                telefone = "4377-5212",
                cpf = "234.432.345-1",
                dataNascimento = "27/06/2997",
                email = "lucasmda27@gmail.com",
                valorDivida = 1.500f
            });
            context.clientes.Add(new Cliente()
            {
                Id = 2,
                nome = "Ivo Mancinelli",
                senha = "123@mudar",
                cep = "043.24.423",
                telefone = "4388-5234",
                cpf = "124.322.455-2",
                dataNascimento = "30/04/1990",
                email = "ivo.mancinelli@gmail.com",
                valorDivida = 4.560f
            });
            context.clientes.Add(new Cliente()
            {
                Id = 3,
                nome = "Natalia Moura",
                senha = "@mudar123",
                cep = "567.33.098",
                telefone = "2388-0912",
                cpf = "342.563.213-23",
                dataNascimento = "24/09/1986",
                email = "natalia.moura@gmail.com",
                valorDivida = 10.883f
            });

            context.produtos.Add(new Produto() { Id = 1, produto = "Aplicativo Deal!" });

            context.usuarios.Add(new Usuario()
            {
                Id = 1,
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
                Id = 2,
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
                Id = 3,
                nome = "Natalia Moura",
                senha = "@mudar123",
                cep = "567.33.098",
                telefone = "2388-0912",
                cpf = "342.563.213-23",
                dataNascimento = "24/09/1986",
                email = "natalia.moura@gmail.com",
                usuario = "nataliamsf"
            });

            context.noticias.Add(new Noticia()
            {
                Id = 1,
                titulo = "Lançamento do aplicativo Deal!",
                descricao = "O melhor aplicativo para renegociação de dívida chegou ao mercado trazendo ótimas vantagens para você sair do vermelho.",
                UsuarioId = 1,
                ProdutoId = 1
            });          

            base.Seed(context);
        }
    }
}