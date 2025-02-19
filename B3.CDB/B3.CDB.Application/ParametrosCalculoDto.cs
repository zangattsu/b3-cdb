using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.CDB.Application
{
    public class ParametrosCalculoDto
    {
        public decimal ValorAplicacaoInicial { get; set; }
        public decimal ValorInvestimentoAdicional { get; set; }
        public int Prazo { get; set; }
        public decimal TaxaJuros { get; set; }
    }
}
