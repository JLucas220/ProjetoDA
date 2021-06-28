using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Participacao
    {
        public override string ToString()
        {
            string participacao = " IdEscola: " + IdEscola + " NrEvento: " + NrEvento + ";";
            return participacao;
        }
    }
}
