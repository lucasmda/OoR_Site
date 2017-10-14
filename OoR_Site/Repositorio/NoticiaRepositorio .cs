using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class NoticiaRepositorio
    {
        private Context.Context _context;

        public NoticiaRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Noticia> GetNoticias()
        {
            return _context.noticias;
        }

        public Noticia GetNoticiaById(int id)
        {
            return _context.noticias.Find(id);
        }

        public void InsertNoticia(Noticia noticia)
        {
            _context.noticias.Add(noticia);
            _context.SaveChanges();
        }

        public void DeleteNoticia(int id)
        {
            var n = _context.noticias.Find(id);
            _context.noticias.Remove(n);
            _context.SaveChanges();

        }

        public void UpdateNoticia(Noticia noticia)
        {
            _context.Entry(noticia).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}