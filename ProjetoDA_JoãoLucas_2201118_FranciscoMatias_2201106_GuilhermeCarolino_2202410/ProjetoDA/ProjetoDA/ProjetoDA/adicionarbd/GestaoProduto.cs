using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoProduto
    {
        projetodaContainer basedados;

        public GestaoProduto()
        {
            basedados = new projetodaContainer();
        }

        public Produto AddProduto(string Designacao, float Preco, int CodTipoProduto, int StockExistente)
        {
            var Produto = new Produto()
            {
                Designacao = Designacao,
                Preco = Preco,
                CodTipoProduto = CodTipoProduto,
                StockExistente = StockExistente,
            };

            basedados.Produto.Add(Produto);
            basedados.SaveChanges();

            return Produto;
        }

        public void AtualizarProduto(int id, string Designacao, int CodTipoProduto, float Preco, int StockExistente)
        {
            var Produto = basedados.Produto.OfType<Produto>().FirstOrDefault(p => p.CodProduto == id);

           
            Produto.Designacao = Designacao;
            Produto.CodTipoProduto = CodTipoProduto;
            Produto.Preco = Preco;
            Produto.StockExistente = StockExistente;



            basedados.SaveChanges();
        }


        public List<Produto> GetProduto()
        {
            var obj = basedados.Produto.Where(p => p is Produto).ToList().Select(f => (Produto)f).ToList();
            return obj;
        }
    }
}
