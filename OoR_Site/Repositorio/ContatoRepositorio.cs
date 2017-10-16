using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class ContatoRepositorio
    {
        private Context.Context _context;

        public ContatoRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Contato> GetContatos()
        {
            return _context.contatos;
        }

        public Contato GetContatoById(int id)
        {
            return _context.contatos.Find(id);
        }

        public void InsertContato(Contato contato)
        {
            _context.contatos.Add(contato);
            _context.SaveChanges();
        }

        public void DeleteContato(int id)
        {
            var c = _context.contatos.Find(id);
            _context.contatos.Remove(c);
            _context.SaveChanges();

        }

        public void UpdateContato(Contato contato)
        {
            _context.Entry(contato).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}