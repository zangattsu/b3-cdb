using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3.CDB.Domain.Entities
{
    public class MedidaExercicio
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Descricao { get; set;} = string.Empty;
        public decimal Percentual { get; set; }

        // ToDo: Verificar se é necessário
    }
}
