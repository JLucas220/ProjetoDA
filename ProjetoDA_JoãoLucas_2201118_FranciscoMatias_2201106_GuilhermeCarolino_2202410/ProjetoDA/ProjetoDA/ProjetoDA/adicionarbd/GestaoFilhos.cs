using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoFilhos
    {
        projetodaContainer basedados;

        public GestaoFilhos()
        {
            basedados = new projetodaContainer();
        }

        public Filho AddFilho(string nomef, string moradaf, string localidadef, string codPostalf, string telefonef, string telemovelf, string mailf, string sexof, int idescolaf, int idprogenitorf, DateTime datanascimentof)
        {
            var filho = new Filho()
            {
                Nome = nomef,
                Morada = moradaf,
                Localidade = localidadef,
                CodPostal = codPostalf,
                Telefone = telefonef,
                Telemovel = telemovelf,
                Mail = mailf,
                Sexo = sexof,
                IdEscola = idescolaf,
                IdProgenitor = idprogenitorf,
                DataNascimento = datanascimentof,
               
            };

            basedados.Pessoa.Add(filho);
            basedados.SaveChanges();

            return filho;
        }

        public void AtualizarFilho(int id, string nomef, string moradaf, string telemovelf, string telefonef,  string mailf, string localidadef, string codPostalf)
        {
            var filho = basedados.Pessoa.OfType<Filho>().FirstOrDefault(p => p.IdPessoa == id);

            filho.Nome = nomef;
            filho.Morada = moradaf;
            filho.Telemovel = telemovelf;
            filho.Telefone = telefonef;
            filho.Mail = mailf;
            filho.Localidade = localidadef;
            filho.CodPostal = codPostalf;


            basedados.SaveChanges();
        }

        public Filho RemoverFilho(int id)
        {
            var filho = basedados.Pessoa.FirstOrDefault(p => p.IdPessoa == id);

            basedados.Pessoa.Remove(filho);
            basedados.SaveChanges();

            return (Filho)filho;
        }


        public List<Filho> Getfilho()
        {
            var obj = basedados.Pessoa.Where(p => p is Filho).ToList().Select(f => (Filho)f).ToList();
           
            return obj;
        }
    }
}
