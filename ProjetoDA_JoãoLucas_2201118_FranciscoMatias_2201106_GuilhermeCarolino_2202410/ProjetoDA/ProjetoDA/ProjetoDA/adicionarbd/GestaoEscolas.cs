using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoEscolas
    {

        projetodaContainer basedados;

        public GestaoEscolas()
        {
            basedados = new projetodaContainer();
        }

        public Escola AddEscola(string nome, string morada, string localidade, string codPostal, string telefone, string mail)
        {
            var escola = new Escola()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                Codpostal = codPostal,
                Telefone = telefone,
                Mail = mail,
               

            };

            basedados.Escola.Add(escola);
            basedados.SaveChanges();

            return escola;
        }

        public void AtualizarEscola(int id, string nome, string morada, string telefone, string mail, string localidade, string codPostal)
        {
            var escola = basedados.Escola.OfType<Escola>().FirstOrDefault(p => p.IdEscola == id);

            escola.Nome = nome;
            escola.Morada = morada;
            escola.Telefone = telefone;
            escola.Mail = mail;
            escola.Localidade = localidade;
            escola.Codpostal = codPostal;
         
           

            basedados.SaveChanges();
        }

        public Escola RemoverEscola(int id)
        {
            var escola = basedados.Escola.FirstOrDefault(p => p.IdEscola == id);
            
            basedados.Escola.Remove(escola);
            basedados.SaveChanges();

            return (Escola)escola;
        }
        public List<Escola> GetEscola()
        {
            var obj = basedados.Escola.Where(p => p is Escola).ToList().Select(f => (Escola)f).ToList();

            return obj;
        }
    }
}
