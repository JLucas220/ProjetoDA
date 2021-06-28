using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Evento
    {
        public override string ToString()
        {
            string evento = "NrEvento: " + NrEvento + " Descrição: " + Descricao + ", Local: " + Local + ", DataHora: " + DataHora + ", LimiteParticipacao: " + LimiteParticipacao + ", IdadeInferior: " + IdadeInferior + ", IdadeSuperior: " + IdadeSuperior + "TipoEvento: " + TipoEvento + ";";
            return evento;
        }
    }
}
