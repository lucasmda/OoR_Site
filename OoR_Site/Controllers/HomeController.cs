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
            var noticias = dbNoticia.GetNoticias();
            var produtos = dbProduto.GetProdutos();
            return View(noticias);
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
                return RedirectToAction("CadastroSenha");
            }

            return View(cliente);
        }

        public ActionResult CadastroSenha()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CadastroSenha([Bind(Include = "senha")]Cliente cliente)
        {
            dbCliente.UpdateCliente(cliente);
            return View(cliente);
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