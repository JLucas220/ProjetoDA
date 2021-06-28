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
    public partial class GestaoAnimadores : Form
    {
        adicionarbd.GestaoAnimadores animador = new adicionarbd.GestaoAnimadores();
        

        private projetodaContainer basedados;
        public GestaoAnimadores()
        {
            InitializeComponent();
            listBox1.DataSource = animador.GetAnimador();
        }

        private void voltaraoform_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPrincipal sistema = new FormPrincipal();
            sistema.ShowDialog();
            this.Close();
        }

        private void criarbutton_Click(object sender, EventArgs e)
        {
            animador.AddAnimador(nome.Text, morada.Text, telemovel.Text, telefone.Text, mail.Text, localidade.Text, codPostal.Text, especialidade.Text);

            listBox1.DataSource = animador.GetAnimador();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animador animador1 = (Animador)listBox1.SelectedItem;

            int id = Convert.ToInt32(animador1.IdPessoa);

            animador.AtualizarAnimador(id,textBox6.Text, textBox5.Text, textBox4.Text, textBox3.Text, textBox2.Text, textBox11.Text, textBox10.Text, textBox9.Text);

            listBox1.DataSource = animador.GetAnimador();
        }

       

        private void removeranimadorbutton_Click_1(object sender, EventArgs e)
        {
            var animador1 = (Animador)listBox1.SelectedItem;
            var id = animador1.IdPessoa;
            animador.RemoverAnimador(Convert.ToInt32(id));

            listBox1.DataSource = animador.GetAnimador();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animador p = (Animador)listBox1.SelectedItem;

            textBox6.Text = p.Nome;
            textBox5.Text = p.Morada;
            textBox4.Text = p.Telemovel;
            textBox3.Text = p.Telefone;
            textBox2.Text = p.Mail;
            textBox11.Text = p.CodPostal;
            textBox10.Text = p.Localidade;
            textBox9.Text = p.Especialidade;
        }
    }
}
