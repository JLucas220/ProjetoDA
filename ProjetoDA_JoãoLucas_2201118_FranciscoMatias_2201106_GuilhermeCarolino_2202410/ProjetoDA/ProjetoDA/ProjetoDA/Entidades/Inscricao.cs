using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Inscricao
    {
        public override string ToString()
        {
            string Inscricao = " FilhoIdPessoa: " + FilhoIdPessoa + " EventosNrEvento: " + EventoNrEvento + ";";
            return Inscricao;
        }
    }
}
