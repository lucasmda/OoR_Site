using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using OoR_Site.Context;
using OoR_Site.Models;

namespace OoR_Site.Models
{
    public class NoticiaDBInitializer : DropCreateDatabaseAlways<Context.Context>
    {
        protected override void Seed(Context.Context context)
        {
            context.noticias.Add(new Noticia()
            {
                descricao = "Lançamento do aplicativo Deal!" +
                "O melhor aplicativo para renegociação de dívida chegou ao mercado trazendo ótimas vantagens para você sair do vermelho.",
                id_produto = 1,
                id_usuario = 1
            });

            base.Seed(context);
        }
    }
}