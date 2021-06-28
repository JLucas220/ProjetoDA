using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoClientesFilhos sistema = new GestaoClientesFilhos();
            sistema.ShowDialog();
            this.Close();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoVendasProdutos sistema = new GestaoVendasProdutos();
            sistema.ShowDialog();
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoEventos sistema = new GestaoEventos();
            sistema.ShowDialog();
            this.Close();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoProdutosVendidos sistema = new GestaoProdutosVendidos();
            sistema.ShowDialog();
            this.Close();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoEscolas sistema = new GestaoEscolas();
            sistema.ShowDialog();
            this.Close();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestaoAnimadores sistema = new GestaoAnimadores();
            sistema.ShowDialog();
            this.Close();
        }
    }
}
