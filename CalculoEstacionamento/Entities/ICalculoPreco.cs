using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstacionamento.Entities
{
    public interface ICalculoPreco
    {
        public decimal PrecoInicial { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSaida { get; set; }
        public decimal PrecoHora { get; set; }
        public decimal PrecoFinal { get; set; }
    }
}
