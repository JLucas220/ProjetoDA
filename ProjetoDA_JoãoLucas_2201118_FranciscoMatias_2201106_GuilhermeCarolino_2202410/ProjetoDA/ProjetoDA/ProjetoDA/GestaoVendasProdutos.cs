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
    public partial class GestaoVendasProdutos : Form
    {
        adicionarbd.GestaoTipoProduto TipoProduto = new adicionarbd.GestaoTipoProduto();
        adicionarbd.GestaoProduto Produto = new adicionarbd.GestaoProduto();
        
        public GestaoVendasProdutos()
        {
            InitializeComponent();
            listBox1.DataSource = TipoProduto.GetTipoProduto();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal sistema = new FormPrincipal();
            sistema.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.DataSource = Produto.GetProduto();
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = TipoProduto.GetTipoProduto();
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto.AddProduto(designacao.Text, Convert.ToInt32(preco.Value), Convert.ToInt32(codproduto.Value), Convert.ToInt32(stock.Value));

            Lista.DataSource = Produto.GetProduto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Produto produto1 = (Produto)Lista.SelectedItem;

            int id = produto1.CodTipoProduto;

            Produto.AtualizarProduto(Convert.ToInt32(id), textBox4.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value));

            listBox1.DataSource = Produto.GetProduto();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TipoProduto.AddTipoProduto(Tipo.Text);

            listBox1.DataSource = TipoProduto.GetTipoProduto();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoProduto p = (TipoProduto)listBox1.SelectedItem;
            textBox10.Text = p.Tipo;
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var tipoproduto1 = (TipoProduto)listBox1.SelectedItem;

            var id = tipoproduto1.CodTipoProduto;


            TipoProduto.AtualizarTipoProduto(Convert.ToInt32(id), textBox10.Text);

            listBox1.DataSource = TipoProduto.GetTipoProduto();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Produto p = (Produto)Lista.SelectedItem;

            textBox4.Text = p.Designacao;
            numericUpDown1.Value = Convert.ToInt32(p.Preco);
            numericUpDown2.Value = Convert.ToInt32(p.CodProduto);
            numericUpDown3.Value = p.StockExistente;


        }

        private void button9_Click(object sender, EventArgs e)
        {
            var tipoproduto1 = (TipoProduto)listBox1.SelectedItem;

            var id = tipoproduto1.CodTipoProduto;

            TipoProduto.RemoverTipoProduto(Convert.ToInt32(id));

            listBox1.DataSource = TipoProduto.GetTipoProduto();
        }
    }
}
