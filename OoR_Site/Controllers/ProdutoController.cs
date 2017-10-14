using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Models;
using OoR_Site.Repositorio;

namespace OoR_Site.Controllers
{
    public class ProdutoController : Controller
    {
        private ProdutoRepositorio db = new ProdutoRepositorio();
        
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            db.InsertProduto(produto);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var produtos = db.GetProdutos();

            return View("Index", produtos);
        }

        public ActionResult Delete(int id)
        {
            db.DeleteProduto(id);

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            var produto = db.GetProdutoById(id);
            
            return View(produto);
        }

        [HttpPost]
        public ActionResult Editar(Produto produto)
        {
            db.UpdateProduto(produto);

            return RedirectToAction("List");
        }
    }
}