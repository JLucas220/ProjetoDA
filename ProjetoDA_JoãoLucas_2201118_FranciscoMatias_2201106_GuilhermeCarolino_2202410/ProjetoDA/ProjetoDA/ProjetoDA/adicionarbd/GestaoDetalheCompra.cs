using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoDetalheCompra
    {
        projetodaContainer basedados;

        public GestaoDetalheCompra()
        {
            basedados = new projetodaContainer();
        }

        public DetalheCompra AddDetalheCompra(string Quantidade,int ComprasNrCompra, int ProdutoCodProduto)
        {
            var DetalheCompra = new DetalheCompra()
            {
                Quantidade = Quantidade,
                ComprasNrCompras = ComprasNrCompra,
                ProdutoCodProduto = ProdutoCodProduto,
            };

            basedados.DetalheCompra.Add(DetalheCompra);
            basedados.SaveChanges();

            return DetalheCompra;
        }



        public List<DetalheCompra> GetDetalheCompra()
        {
            var obj = basedados.DetalheCompra.Where(p => p is DetalheCompra).ToList().Select(f => (DetalheCompra)f).ToList();
            return obj;
        }
    }
}
