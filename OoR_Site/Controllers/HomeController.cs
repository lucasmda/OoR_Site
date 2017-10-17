using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Models;
using OoR_Site.Repositorio;

namespace OoR_Site.Controllers
{
    public class HomeController : Controller
    {
        ContatoRepositorio dbContato = new ContatoRepositorio();
        ClienteRepositorio dbCliente = new ClienteRepositorio();
        NoticiaRepositorio dbNoticia = new NoticiaRepositorio();
        ProdutoRepositorio dbProduto = new ProdutoRepositorio();

        public ActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel();
            hvm.noticias = dbNoticia.GetNoticias();
            hvm.produtos = dbProduto.GetProdutos();
            return View(hvm);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Client()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Client([Bind(Include = "cpf")]Cliente cliente)
        {
            Boolean validaCpf = dbCliente.ValidaCpf(cliente);

            if (validaCpf)
            {
                var c = dbCliente.BuscaCpf(cliente);
                return RedirectToAction("CadastroSenha", "Home", new { Id = c.Id });
            }

            return View(cliente);
        }

        public ActionResult CadastroSenha(int Id)
        {
            var c = dbCliente.GetClienteById(Id);
            return View(c);
        }

        [HttpPost]
        public ActionResult CadastroSenha([Bind(Include = "Id, senha")]Cliente cliente)
        {
            var c = dbCliente.GetClienteById(cliente.Id);
            c.senha = cliente.senha;
            dbCliente.UpdateCliente(c);
            return RedirectToAction("Index");
        }

        public ActionResult NotClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NotClient([Bind(Include = "nome, email, telefone")]Contato contato)
        {
            dbContato.InsertContato(contato);
            return RedirectToAction("Index");
        }
    }
}