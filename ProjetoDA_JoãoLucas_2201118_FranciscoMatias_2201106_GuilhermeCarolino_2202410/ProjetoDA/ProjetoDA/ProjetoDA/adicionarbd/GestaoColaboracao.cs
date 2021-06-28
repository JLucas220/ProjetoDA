using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoColaboracao
    {
        projetodaContainer basedados;

        public GestaoColaboracao()
        {
            basedados = new projetodaContainer();
        }

        public Colaboracao AddColaboracao(int IdAnimador, int NrEvento)
        {
            var colaboracao = new Colaboracao()
            {
                IdAnimador = IdAnimador,
                NrEvento = NrEvento,
            };

            basedados.Colaboracao.Add(colaboracao);
            basedados.SaveChanges();

            return colaboracao;
        }



        public List<Colaboracao> GetColaboracao()
        {
            var obj = basedados.Colaboracao.Where(p => p is Colaboracao).ToList().Select(f => (Colaboracao)f).ToList();
            return obj;
        }
    }
}
