using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoEstacionamento.Exceções
{
    internal class ExcecoesPrincipais: ApplicationException
    {
        public ExcecoesPrincipais(string msg): base(msg)
        {
        }
    }
}
