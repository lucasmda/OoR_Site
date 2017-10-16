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

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "titulo, descricao, id_usuario, id_produto")]Noticia noticia)
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

            return View(noticia);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, titulo, descricao, id_usuario, id_produto")]Noticia noticia)
        {
            db.UpdateNoticia(noticia);

            return RedirectToAction("List");
        }
    }
}