using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class ProdutoRepositorio
    {
        private Context.Context _context;

        public ProdutoRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return _context.produtos;
        }

        public Produto GetProdutoById(int id)
        {
            return _context.produtos.Find(id);
        }

        public void InsertProduto(Produto p)
        {
            _context.produtos.Add(p);
            _context.SaveChanges();
        }

        public void DeleteProduto(int id)
        {
            var p = _context.produtos.Find(id);
            _context.produtos.Remove(p);
            _context.SaveChanges();

        }

        public void UpdateProduto(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}