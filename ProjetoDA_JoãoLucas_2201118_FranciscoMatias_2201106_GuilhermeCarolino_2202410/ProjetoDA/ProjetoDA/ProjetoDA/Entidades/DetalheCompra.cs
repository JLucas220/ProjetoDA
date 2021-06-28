using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class DetalheCompra
    {
        public override string ToString()
        {
            string DetalheCompra = " Quantidade: " + Quantidade + " ComprasNrCompra: " + ComprasNrCompras + " ProdutoCodProduto: " + ProdutoCodProduto + ";";
            return DetalheCompra;
        }
    }
}
