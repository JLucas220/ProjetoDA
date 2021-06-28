using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class Compra
    {
        public override string ToString()
        {
            string compra = " Nrcompra: " + NrCompra + " Data: " + Data + " UtilizouCartao: " + UtilizouCartao + " IdCliente: " + IdCliente + " ProdutosCodProduto: " + ProdutosCodProduto + ";";
            return compra;
        }
    }
}
