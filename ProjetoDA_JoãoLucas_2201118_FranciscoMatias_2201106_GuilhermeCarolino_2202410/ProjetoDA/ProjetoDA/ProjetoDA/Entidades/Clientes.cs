using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Cliente
    {
        public override string ToString()
        {
            string cliente = "ID: " + IdPessoa + ", Nome: " + Nome + ", Morada: " + Morada + ", Localidade: " + Localidade + ", Telefone: " + Telefone + ", Telemovel: " + Telemovel + ", Mail: " + Mail + ", Codigo-Postal: " + CodPostal + ", Número de cartão: " + NrCartao + ", Valor de Oferta: " + ValorOferta + ";";
            return cliente;
        }
    }
}
