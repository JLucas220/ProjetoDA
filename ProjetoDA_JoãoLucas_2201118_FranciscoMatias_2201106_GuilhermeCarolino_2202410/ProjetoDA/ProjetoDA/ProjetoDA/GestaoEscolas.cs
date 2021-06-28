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
    public partial class GestaoEscolas : Form

    {
        adicionarbd.GestaoEscolas escola = new adicionarbd.GestaoEscolas();
        private projetodaContainer basedados;
        public GestaoEscolas()
        {
            InitializeComponent();
            listBox1.DataSource = escola.GetEscola();

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
            escola.AddEscola(nome.Text, morada.Text, telefone.Text, mail.Text, localidade.Text, codPostal.Text);

            listBox1.DataSource = escola.GetEscola();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var escola1 = (Escola)listBox1.SelectedItem;

            var id = escola1.IdEscola;

            escola.AtualizarEscola(Convert.ToInt32(id), textBox7.Text, textBox6.Text, textBox5.Text, textBox4.Text, textBox2.Text, textBox3.Text);

            listBox1.DataSource = escola.GetEscola();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Escola p = (Escola)listBox1.SelectedItem;

            textBox7.Text = p.Nome;
            textBox6.Text = p.Morada;
            textBox5.Text = p.Telefone;
            textBox4.Text = p.Mail;
            textBox2.Text = p.Localidade;
            textBox3.Text = p.Codpostal;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var escola1 = (Escola)listBox1.SelectedItem;

            var id = escola1.IdEscola;

            escola.RemoverEscola(Convert.ToInt32(id));

            listBox1.DataSource = escola.GetEscola();

        }

        
        
    
    }
}
