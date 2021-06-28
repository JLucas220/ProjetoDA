using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Produto
    {
        public override string ToString()
        {
            string Produto = " CodProduto: " + CodProduto + " Designacao: " + Designacao + " Preco: " + Preco + " CodTipoProduto: " + CodTipoProduto + " StockExistente: " + StockExistente +";";
            return Produto;
        }
    }
}
