using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Filho
    {
        public override string ToString()
        {
            string cliente = "IdFilho" + IdPessoa + " Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Telemovel: " + Telemovel + ", Mail: " + Mail + ", Codigo-Postal: " + CodPostal + ", Sexo: " + Sexo + ", Id Escola: " + IdEscola + ", Id Progenitor: " + IdProgenitor + ", Data Nascimento: " + DataNascimento + ";";
            return cliente;
        }
    }
}
