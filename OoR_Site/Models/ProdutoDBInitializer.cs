using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_Site.Context;
using OoR_Site.Models;

namespace OoR_Site.Models
{
    public class ProdutoDBInitializer : DropCreateDatabaseAlways<Context.Context>
    {
        protected override void Seed(Context.Context context)
        {
            context.produtos.Add(new Produto() { produto = "Aplicativo Deal!" });

            base.Seed(context);
        }
    }
}