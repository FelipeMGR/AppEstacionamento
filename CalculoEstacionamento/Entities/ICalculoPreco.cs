using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstacionamento.Entities
{
    interface ICalculoPreco
    {
        public decimal PrecoInicial { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSaida { get; set; }
        public decimal PrecoHora { get; set; }
        public decimal PrecoFinal { get; set; }

        public decimal CalculoPreco(decimal precoHora, decimal precoInicial, TimeSpan horaentrada, TimeSpan horasaida)
        {
            TimeSpan totalHoras = TimeSpan.FromHours(horaentrada.Hours).Subtract(horasaida);

            if (totalHoras.Hours > 12)
            {
                decimal precoFinal = precoInicial + totalHoras.Hours * precoHora * 2;
                return precoFinal;
            }
            else

                return totalHoras.Hours * precoHora + precoInicial;

        }
    }
}
