using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Colaboracao
    {
        public override string ToString()
        {
            string colaboracao = " IdAnimador: " + IdAnimador + " NrEvento: " + NrEvento + ";";
            return colaboracao;
        }
    }
}
