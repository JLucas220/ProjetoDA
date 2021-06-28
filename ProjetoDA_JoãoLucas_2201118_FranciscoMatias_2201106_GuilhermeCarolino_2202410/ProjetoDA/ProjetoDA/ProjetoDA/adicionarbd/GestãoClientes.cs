using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestãoClientes
    {
        projetodaContainer basedados;

        public GestãoClientes()
        {
            basedados = new projetodaContainer();
        }

        public Cliente AddCliente(string nome, string morada, string localidade, string codPostal, string telefone, string telemovel, string mail, string nCartao, string valoroferta)
        {
            var cliente = new Cliente()
            {
                Nome = nome,
                Morada = morada,
                Localidade = localidade,
                CodPostal = codPostal,
                Telefone = telefone,
                Telemovel = telemovel,
                Mail = mail,
                NrCartao = nCartao,
                ValorOferta = valoroferta,
            };

            basedados.Pessoa.Add(cliente);
            basedados.SaveChanges();

            return cliente;

        }

            public void AtualizarCliente(int id, string nome, string morada, string telemovel, string telefone, string mail, string localidade, string codPostal)
            {
                var cliente = basedados.Pessoa.OfType<Cliente>().FirstOrDefault(p => p.IdPessoa == id);

                cliente.Nome = nome;
                cliente.Morada = morada;
                cliente.Telemovel = telemovel;
                cliente.Telefone = telefone;
                cliente.Mail = mail;
                cliente.Localidade = localidade;
                cliente.CodPostal = codPostal;
             
                

                basedados.SaveChanges();
            }

        public Cliente RemoverCliente(int id)
        {
            var cliente = basedados.Pessoa.FirstOrDefault(p => p.IdPessoa == id);

            basedados.Pessoa.Remove(cliente);
            basedados.SaveChanges();

            return (Cliente)cliente;
        }

        public List<Cliente> GetCliente()
        {
            var obj = basedados.Pessoa.Where(p => p is Cliente).ToList().Select(f => (Cliente)f).ToList();

            return obj;
        }
    }
}

