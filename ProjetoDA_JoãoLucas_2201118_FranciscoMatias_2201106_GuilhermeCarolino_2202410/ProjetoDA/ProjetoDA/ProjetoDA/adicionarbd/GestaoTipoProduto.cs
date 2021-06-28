using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.adicionarbd
{
    class GestaoTipoProduto
    {
        projetodaContainer basedados;

        public GestaoTipoProduto()
        {
            basedados = new projetodaContainer();
        }

        public TipoProduto AddTipoProduto(string Tipo)
        {
            var TipoProduto = new TipoProduto()
            {
                Tipo = Tipo,
                
            };

            basedados.TipoProduto.Add(TipoProduto);
            basedados.SaveChanges();

            return TipoProduto;
        }

        public void AtualizarTipoProduto(int id, string tipo)
        {
            var tipoproduto = basedados.TipoProduto.OfType<TipoProduto>().FirstOrDefault(p => p.CodTipoProduto == id);

            tipoproduto.Tipo = tipo;
          
            basedados.SaveChanges();
        }

        public TipoProduto RemoverTipoProduto(int id)
        {
            var tipoproduto = basedados.TipoProduto.FirstOrDefault(p => p.CodTipoProduto == id);

            basedados.TipoProduto.Remove(tipoproduto);
            basedados.SaveChanges();

            return (TipoProduto)tipoproduto;
        }

        public List<TipoProduto> GetTipoProduto()
        {
            var obj = basedados.TipoProduto.Where(p => p is TipoProduto).ToList().Select(f => (TipoProduto)f).ToList();
            return obj;
        }
    }
}
