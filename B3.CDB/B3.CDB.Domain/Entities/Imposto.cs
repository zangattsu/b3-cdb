using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.CDB.Domain.Entities
{
    public class Imposto
    {
        public int Id { get; set; }
        public int AteQueMes { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public decimal Percentual { get; set; }
    }
}
