﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA
{
    public partial class TipoProduto
    {
        public override string ToString()
        {
            string TipoProduto = " Tipo: " + Tipo + " CodTipoProduto: " + CodTipoProduto + ";";
            return TipoProduto;
        }
    }
}
