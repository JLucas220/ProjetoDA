using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestãoEventos
    {
        projetodaContainer basedados;

        public GestãoEventos()
        {
            basedados = new projetodaContainer();
            
        }

        public Evento AddEvento(string descricao, string local, string datahora, string limiteparticipacao, string idadeinferior, string idadesuperior, string tipoevento)
        {
            var evento = new Evento()
            {
                Descricao = descricao,
                Local = local,
                DataHora = datahora,
                LimiteParticipacao = limiteparticipacao,
                IdadeInferior = idadeinferior,
                IdadeSuperior= idadesuperior,
                TipoEvento = tipoevento,



            };

            basedados.Evento.Add(evento);
            basedados.SaveChanges();

            return evento;
        }

        public void AtualizarEvento(int id, string descricao, string local, string datahora, string idadeinferior, string idadesuperior, string limiteparticipacao,  string tipoevento)
        {
            var evento = basedados.Evento.OfType<Evento>().FirstOrDefault(p => p.NrEvento == id);

            evento.Descricao = descricao;
            evento.Local = local;
            evento.DataHora = datahora;
            evento.IdadeInferior = idadeinferior;
            evento.IdadeSuperior = idadesuperior;
            evento.LimiteParticipacao = limiteparticipacao;
            
            evento.TipoEvento = tipoevento;



            basedados.SaveChanges();
        }

        public Evento RemoverEvento(int id)
        {
            var evento = basedados.Evento.FirstOrDefault(p => p.NrEvento == id);

            basedados.Evento.Remove(evento);
            basedados.SaveChanges();

            return (Evento)evento;
        }


        public List<Evento> GetEvento()
        {
            var obj = basedados.Evento.Where(p => p is Evento).ToList().Select(f => (Evento)f).ToList();

            return obj;
        }


    }
}
