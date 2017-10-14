using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_Site.Models;

namespace OoR_Site.Context
{
    public class Context : DbContext
    {
        public Context() : base("oor_site")
        {
            //Database.SetInitializer(new ProdutoDBInitializer());
            //Database.SetInitializer(new ClienteDBInitializer());
            Database.SetInitializer(new NoticiaDBInitializer());
        }

        public DbSet<Produto> produtos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Noticia> noticias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}