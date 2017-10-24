using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OoR_Site.Models
{
    public class ClienteOpcao
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int OpcoesInvestimentoId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual OpcoesInvestimento OpcoesInvestimento { get; set; }

        public IEnumerable<ClienteOpcao> cops { get; set; }
    }
}