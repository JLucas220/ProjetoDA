using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoParticipacao
    {
        projetodaContainer basedados;

        public GestaoParticipacao()
        {
            basedados = new projetodaContainer();
        }

        public Participacao AddParticipacao(int IdEscola, int NrEvento )
        {
            var participacao = new Participacao()
            {
                IdEscola = IdEscola,
                NrEvento = NrEvento,
            };

            basedados.Participacao.Add(participacao);
            basedados.SaveChanges();

            return participacao;
        }



        public List<Participacao> GetParticipacao()
        {
            var obj = basedados.Participacao.Where(p => p is Participacao).ToList().Select(f => (Participacao)f).ToList();
            return obj;
        }
    }
}
