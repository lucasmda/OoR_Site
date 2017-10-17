using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Context;
using OoR_Site.Models;
using OoR_Site.Repositorio;

namespace OoR_Site.Controllers
{
    public class ContatoController : Controller
    {
        ContatoRepositorio db = new ContatoRepositorio();
        
        public ActionResult Index()
        {
            return View(db.GetContatos());
        }
        
        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search([Bind(Include = "nome, email, telefone")]Contato contato)
        {
            contato.contatos = db.Search(contato);
            
            if(contato != null)
            {
                return View("SearchResult", contato);
            }

            return View(contato);
        }
    }
}
