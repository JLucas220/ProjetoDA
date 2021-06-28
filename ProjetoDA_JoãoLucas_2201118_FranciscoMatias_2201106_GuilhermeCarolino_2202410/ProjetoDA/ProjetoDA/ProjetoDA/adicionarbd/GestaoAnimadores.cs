using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoAnimadores
    {

        projetodaContainer basedados;

        public GestaoAnimadores()
        {
            basedados = new projetodaContainer();
        }

        public Animador AddAnimador(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string especialidade)
        {
            var animador = new Animador()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                CodPostal = codPostal,
                Telefone = telefone,
                Telemovel = telemovel,
                Mail = mail,
                Especialidade = especialidade,
              
            };

            basedados.Pessoa.Add(animador);
            basedados.SaveChanges();

            return animador;
        }

        public void AtualizarAnimador(int id, string nome, string morada, string telemovel, string telefone, string mail, string codPostal, string localidade, string especialidade)
        {
            var animador = basedados.Pessoa.OfType<Animador>().FirstOrDefault(p => p.IdPessoa == id);

            animador.Nome = nome;
            animador.Morada = morada;

            animador.Telemovel = telemovel;
            animador.Telefone = telefone;
            
            animador.Mail = mail;
            animador.CodPostal = codPostal;
            animador.Localidade = localidade;
            animador.Especialidade = especialidade;


            basedados.SaveChanges();
        }

        public Animador RemoverAnimador(int id)
        {
            var animador = basedados.Pessoa.FirstOrDefault(p => p.IdPessoa == id);

            basedados.Pessoa.Remove(animador);
            basedados.SaveChanges();

            return (Animador)animador;
        }

        public List<Animador> GetAnimador()
        {
            var obj = basedados.Pessoa.Where(p => p is Animador).ToList().Select(f => (Animador)f).ToList();

            return obj;
        }
    }
}
