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
        private ClienteRepositorio dbCliente = new ClienteRepositorio();

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

        public ActionResult Investir(int id)
        {
            var oi = db.GetOpcoesById(id);
            ViewBag.Opcoes = db.GetOpcoes();
            return View(oi);
        }

        [HttpPost]
        public ActionResult Investir([Bind(Include = "Opcao, Quantidade, Cpf, Senha")]int opcao, int quantidade, Cliente cliente)
        {
            var oi = db.GetOpcoesById(opcao);

            if(oi.quantidade >= quantidade)
            {
                var c = dbCliente.BuscaCpf(cliente);

                if (c != null && c.senha == cliente.senha)
                {
                    db.UpdateOpcoesQuantidade(oi, quantidade);
                   // db.InsertClienteOpcao(oi, cliente);
                }else
                {
                    ViewBag.Errors = "Cpf ou Senha inválido.";
                    ViewBag.Opcoes = db.GetOpcoes();
                    return View();
                }
            }else
            {
                ViewBag.Errors = "Quantidade maior do que a disponível.";
                ViewBag.Opcoes = db.GetOpcoes();
                return View();
            }
            
            return RedirectToAction("Index", "Home");
        }

        public ActionResult InvestimentosComprados()
        {
            ClienteOpcao cop = new ClienteOpcao();
            cop.cops = db.Investimentos();
            return View(cop);
        }

        public ActionResult Search()
        {
            ViewBag.Opcoes = db.GetOpcoes();
            return View();
        }

        [HttpPost]
        public ActionResult Search([Bind(Include = "Nome")]string nome)
        {
            ClienteOpcao cop = new ClienteOpcao();
            cop.cops = db.Search(nome);
            float valorTotal = 0;

            if (cop != null)
            {
                foreach(var item in cop.cops) {
                    valorTotal += item.OpcoesInvestimento.valor;
                }
                ViewBag.ValorTotal = valorTotal;
                return View("SearchResult", cop);
            }
            return View();
        }
    }
}