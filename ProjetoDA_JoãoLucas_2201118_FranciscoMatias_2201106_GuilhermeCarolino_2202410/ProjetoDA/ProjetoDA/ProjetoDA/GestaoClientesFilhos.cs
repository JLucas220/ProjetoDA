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
    public partial class GestaoClientesFilhos : Form
    {
        adicionarbd.GestãoClientes clientes = new adicionarbd.GestãoClientes();
        adicionarbd.GestaoFilhos filhos = new adicionarbd.GestaoFilhos();

        private projetodaContainer basedados;
        public GestaoClientesFilhos()
        {
          
            InitializeComponent();
            
        }

        private void criarbutton_Click(object sender, EventArgs e)
        {
            clientes.AddCliente(nome.Text, morada.Text, telemovel.Text, telefone.Text, mail.Text, localidade.Text, codpostal.Text, nrcartao.Text, valoroferta.Text);

            Lista.DataSource = clientes.GetCliente();
        }

        private void voltaraoform_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal sistema = new FormPrincipal();
            sistema.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lista.DataSource = clientes.GetCliente();
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

        }

        private void GestaoClientesFilhos_Load(object sender, EventArgs e)
        {
            basedados = new projetodaContainer();
            LerDados();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = filhos.Getfilho();
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            filhos.AddFilho(nomef.Text, moradaf.Text, telemovelf.Text, telefonef.Text, mailf.Text, localidadef.Text, codPostalf.Text, sexof.Text, Convert.ToInt32(idescolaf.Value), Convert.ToInt32(idprogenitorf.Value), datanascimentof.Value);

            listBox1.DataSource = filhos.Getfilho();
        }

        private void LerDados()
        {
            Lista.DataSource = clientes.GetCliente(); 
           
        }
       

        private void removerclientebutton_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)Lista.SelectedItem;
            var id = cliente.IdPessoa;
            clientes.RemoverCliente(Convert.ToInt32(id));
            basedados.SaveChanges();

            LerDados();


        }

        private void Lista_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa p = (Pessoa)Lista.SelectedItem;

            textBox10.Text = p.Nome;
            textBox9.Text = p.Morada;
            textBox8.Text = p.Telemovel;
            textBox7.Text = p.Telefone;
            textBox6.Text = p.Mail;
            textBox5.Text = p.Localidade;
            textBox4.Text = p.CodPostal;
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var filho = (Filho)listBox1.SelectedItem;

            var id = filho.IdPessoa;


            filhos.AtualizarFilho(Convert.ToInt32(id),textBox29.Text, textBox28.Text, textBox27.Text, textBox26.Text, textBox25.Text, textBox24.Text, textBox23.Text);

            listBox1.DataSource = filhos.Getfilho();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pessoa p = (Pessoa)listBox1.SelectedItem;

            textBox29.Text = p.Nome;
            textBox28.Text = p.Morada;
            textBox27.Text = p.Telemovel;
            textBox26.Text = p.Telefone;
            textBox25.Text = p.Mail;
            textBox24.Text = p.Localidade;
            textBox23.Text = p.CodPostal;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var filho = (Filho)listBox1.SelectedItem;
            var id = filho.IdPessoa;
            filhos.RemoverFilho(Convert.ToInt32(id));
            basedados.SaveChanges();

            listBox1.DataSource = filhos.Getfilho();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)Lista.SelectedItem;

            var id = cliente.IdPessoa;

            clientes.AtualizarCliente(Convert.ToInt32(id), textBox10.Text, textBox9.Text, textBox8.Text, textBox7.Text, textBox6.Text, textBox5.Text, textBox4.Text);

            Lista.DataSource = clientes.GetCliente();
        }
    }
}
