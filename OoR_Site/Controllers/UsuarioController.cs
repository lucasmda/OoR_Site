using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OoR_Site.Models;
using OoR_Site.Repositorio;

namespace OoR_Site.Controllers
{
    public class UsuarioController : Controller
    {
        UsuarioRepositorio db = new UsuarioRepositorio();
        
        [HttpPost]
        public ActionResult Login([Bind(Include = "usuario, senha")]Usuario u)
        {
            Boolean login = db.Login(u);
            
            if (login)
            {
                return RedirectToAction("Index", "Admin");
            }

            return RedirectToAction("Login", "Account");
        }
    }
}