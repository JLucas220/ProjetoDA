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
    public partial class GestaoProdutosVendidos : Form
    {
        adicionarbd.GestaoCompra compra = new adicionarbd.GestaoCompra();
        adicionarbd.GestaoDetalheCompra detalhecompra = new adicionarbd.GestaoDetalheCompra();


        public GestaoProdutosVendidos()
        {
            InitializeComponent();
            
        }

       

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal sistema = new FormPrincipal();
            sistema.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.DataSource = compra.GetCompra();
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = false;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            compra.AddCompra(datacompra.Value, cartao.Text, Convert.ToInt32(idcliente.Value), codproduto.Text);

            Lista.DataSource = compra.GetCompra();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = detalhecompra.GetDetalheCompra();
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox5.Visible = true;
        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            detalhecompra.AddDetalheCompra(quantidade.Text, Convert.ToInt32(nrcompra.Value), Convert.ToInt32(CodigoProduto.Value));

            listBox1.DataSource = detalhecompra.GetDetalheCompra();
        }
    }
}
