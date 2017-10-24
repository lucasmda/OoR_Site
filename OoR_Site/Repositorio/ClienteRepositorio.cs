using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OoR_Site.Models;
using System.Data.Entity;
using OoR_Site.Context;

namespace OoR_Site.Repositorio
{
    public class ClienteRepositorio
    {
        private Context.Context _context;

        public ClienteRepositorio()
        {
            _context = new Context.Context();
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _context.clientes;
        }

        public Cliente GetClienteById(int id)
        {
            return _context.clientes.Find(id);
        }

        public void InsertCliente(Cliente cliente)
        {
            _context.clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void DeleteCliente(int id)
        {
            var c = _context.clientes.Find(id);
            _context.clientes.Remove(c);
            _context.SaveChanges();

        }

        public void UpdateCliente(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public Boolean ValidaCpf(Cliente cliente)
        {
            Boolean result = false;

            var validCpf = _context.clientes.Where(
                c => c.cpf == cliente.cpf
            ).FirstOrDefault();

            if (validCpf != null)
            {
                return result = true;
            }
            return result;
        }

        public Cliente BuscaCpf(Cliente cliente)
        {
            Cliente c;

            c = _context.clientes.Where(model => model.cpf == cliente.cpf).FirstOrDefault();

            return c;
        }

        public int BuscaCpf(string cpf)
        {
            Cliente c = _context.clientes.Where(model => model.cpf == cpf).FirstOrDefault();
            int id = c.Id;
            return id;
        }

        public IEnumerable<Cliente> Search(Cliente cliente)
        {
            return _context.clientes.Where(
                            c => c.nome == cliente.nome ||
                            c.cep == cliente.cep ||
                            c.telefone == cliente.telefone ||
                            c.cpf == cliente.cpf ||
                            c.dataNascimento == cliente.dataNascimento ||
                            c.email == cliente.email ||
                            c.valorDivida == cliente.valorDivida
                          ).ToList();
        }
    }
}