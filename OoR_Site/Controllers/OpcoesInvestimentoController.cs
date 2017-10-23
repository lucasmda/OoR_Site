using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Repositorio;
using OoR_Site.Models;

namespace OoR_Site.Controllers
{
    public class OpcoesInvestimentoController : Controller
    {
        private OpcoesInvestimentoRepositorio db = new OpcoesInvestimentoRepositorio();

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "descricao, valor, quantidade")] OpcoesInvestimento oi)
        {
            db.InsertOpcoes(oi);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var oi = db.GetOpcoes();

            return View("Index", oi);
        }

        public ActionResult Delete(int id)
        {
            db.DeleteOpcoes(id);

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            var oi = db.GetOpcoesById(id);

            return View(oi);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, descricao, valor, quantidade")]OpcoesInvestimento opcoes)
        {
            db.UpdateOpcoes(opcoes);

            return RedirectToAction("List");
        }
    }
}