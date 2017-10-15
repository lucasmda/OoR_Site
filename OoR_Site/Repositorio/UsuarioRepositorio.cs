using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class UsuarioRepositorio
    {
        private Context.Context _context;

        public UsuarioRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Usuario> GetClientes()
        {
            return _context.usuarios;
        }

        public Usuario GetUsuarioById(int id)
        {
            return _context.usuarios.Find(id);
        }

        public void InsertUsuario(Usuario usuario)
        {
            _context.usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void DeleteUsuario(int id)
        {
            var u = _context.usuarios.Find(id);
            _context.usuarios.Remove(u);
            _context.SaveChanges();

        }

        public void UpdateUsuario(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Boolean Login(Usuario user)
        {
            Boolean result = false;

            var validUser = _context.usuarios.Where(
                u => u.usuario == user.usuario &&
                u.senha == user.senha
            ).FirstOrDefault();

            if (validUser != null)
            {
                return result = true;
            }
            return result;
        }
    }
}