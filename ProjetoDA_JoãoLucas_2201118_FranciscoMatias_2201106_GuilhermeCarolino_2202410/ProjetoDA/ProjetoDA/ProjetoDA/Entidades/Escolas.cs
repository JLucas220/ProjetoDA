using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Escola
    {
        public override string ToString()
        {
            string escola =  " ID: " + IdEscola + " Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Mail: " + Mail + ", Codigo-Postal: " + Codpostal + ";";
            return escola;
        }
    }
}
