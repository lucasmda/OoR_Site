using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Repositorio;
using OoR_Site.Models;

namespace OoR_Site.Controllers
{
    public class NoticiaController : Controller
    {
        private NoticiaRepositorio db = new NoticiaRepositorio();
        private UsuarioRepositorio dbUsuario = new UsuarioRepositorio();
        private ProdutoRepositorio dbProduto = new ProdutoRepositorio();

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            ViewBag.Usuarios = dbUsuario.GetUsuarios();
            ViewBag.Produtos = dbProduto.GetProdutos();
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "titulo, descricao, UsuarioId, ProdutoId")]Noticia noticia)
        {
            db.InsertNoticia(noticia);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var noticias = db.GetNoticias();

            return View("Index", noticias);
        }

        public ActionResult Delete(int id)
        {
            db.DeleteNoticia(id);

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            var noticia = db.GetNoticiaById(id);
            ViewBag.Usuarios = dbUsuario.GetUsuarios();
            ViewBag.Produtos = dbProduto.GetProdutos();
            return View(noticia);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, titulo, descricao, UsuarioId, ProdutoId")]Noticia noticia)
        {
            db.UpdateNoticia(noticia);

            return RedirectToAction("List");
        }
    }
}