using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoInscricao
    {
        projetodaContainer basedados;

        public GestaoInscricao()
        {
            basedados = new projetodaContainer();
        }

        public Inscricao AddInscricao(int NrEvento, int FilhoIdPessoa, string Confirmada)
        {
            var inscricao = new Inscricao()
            {
                FilhoIdPessoa = FilhoIdPessoa,
                EventoNrEvento = NrEvento,
                Confirmada = Confirmada,
            };

            basedados.Inscricao.Add(inscricao);
            basedados.SaveChanges();

            return inscricao;
        }



        public List<Inscricao> GetInscricao()
        {
            var obj = basedados.Inscricao.Where(p => p is Inscricao).ToList().Select(f => (Inscricao)f).ToList();
            return obj;
        }
    }
}
