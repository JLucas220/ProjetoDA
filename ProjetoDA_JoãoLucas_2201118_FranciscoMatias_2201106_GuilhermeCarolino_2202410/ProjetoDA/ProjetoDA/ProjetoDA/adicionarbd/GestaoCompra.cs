using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoCompra
    {
        projetodaContainer basedados;

        public GestaoCompra()
        {
            basedados = new projetodaContainer();
        }

        public Compra AddCompra(DateTime data, string UtilizouCartao, int IdCliente, string ProdutosCodProduto)
        {
            var compra = new Compra()
            {
                Data = data,
                UtilizouCartao = UtilizouCartao,
                IdCliente = IdCliente,
                ProdutosCodProduto = ProdutosCodProduto,
            };

            basedados.Compra.Add(compra);
            basedados.SaveChanges();

            return compra;
        }



        public List<Compra> GetCompra()
        {
            var obj = basedados.Compra.Where(p => p is Compra).ToList().Select(f => (Compra)f).ToList();
            return obj;
        }
    }
}
