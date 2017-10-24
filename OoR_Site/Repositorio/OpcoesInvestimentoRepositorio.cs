using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class OpcoesInvestimentoRepositorio
    {
        private Context.Context _context;

        public OpcoesInvestimentoRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<OpcoesInvestimento> GetOpcoes()
        {
            return _context.opcoes;
        }

        public OpcoesInvestimento GetOpcoesById(int id)
        {
            return _context.opcoes.Find(id);
        }

        public void InsertOpcoes(OpcoesInvestimento o)
        {
            _context.opcoes.Add(o);
            _context.SaveChanges();
        }

        public void DeleteOpcoes(int id)
        {
            var c = _context.opcoes.Find(id);
            _context.opcoes.Remove(c);
            _context.SaveChanges();

        }

        public void UpdateOpcoes(OpcoesInvestimento o)
        {
            _context.Entry(o).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void UpdateOpcoesQuantidade(OpcoesInvestimento o, int quantidade)
        {
            o.quantidade = o.quantidade - quantidade;

            _context.Entry(o).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void InsertClienteOpcao(OpcoesInvestimento oi, Cliente c)
        {
            ClienteOpcao cop = new ClienteOpcao();
            cop.ClienteId = c.Id;
            cop.OpcoesInvestimentoId = oi.Id;

            _context.cop.Add(cop);
            _context.SaveChanges();
        }

        public IEnumerable<ClienteOpcao> Investimentos()
        {
            return _context.cop.ToList();
        }

        public IEnumerable<ClienteOpcao> Search(string nome)
        {
            return _context.cop.Where(
                            cop => cop.Cliente.nome == nome
                          ).ToList();
        }
    }

}