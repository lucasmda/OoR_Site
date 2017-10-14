using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Repositorio;
using OoR_Site.Models;

namespace OoR_Site.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio db = new ClienteRepositorio();

        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            db.InsertCliente(cliente);

            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var clientes = db.GetClientes();

            return View("Index", clientes);
        }

        public ActionResult Delete(int id)
        {
            db.DeleteCliente(id);

            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            var cliente = db.GetClienteById(id);

            return View(cliente);
        }

        [HttpPost]
        public ActionResult Editar(Cliente cliente)
        {
            db.UpdateCliente(cliente);

            return RedirectToAction("List");
        }
    }
}