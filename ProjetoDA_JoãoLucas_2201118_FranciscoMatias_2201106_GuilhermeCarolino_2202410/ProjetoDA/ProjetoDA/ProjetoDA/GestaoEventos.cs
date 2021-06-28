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
    public partial class GestaoEventos : Form
    {
        adicionarbd.GestãoEventos evento = new adicionarbd.GestãoEventos();
        adicionarbd.GestaoColaboracao colaboracao = new adicionarbd.GestaoColaboracao();
        adicionarbd.GestaoInscricao inscricao = new adicionarbd.GestaoInscricao();
        adicionarbd.GestaoParticipacao participacao = new adicionarbd.GestaoParticipacao();
        public GestaoEventos()
        {
            InitializeComponent();
            listBox1.DataSource = evento.GetEvento();

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
            evento.AddEvento(descricao.Text, local.Text, datahora.Text, limitepart.Text, idadeinferior.Text, idadesuperior.Text, tipoevento.Text);

            listBox1.DataSource = evento.GetEvento();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = evento.GetEvento();
            groupBox3.Visible = true;
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            groupBox8.Visible = true;
            groupBox4.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox9.Visible = false;
            


        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox5.Visible = true;
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox8.Visible = false;
            
            groupBox9.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = colaboracao.GetColaboracao();
            groupBox6.Visible = true;
            groupBox5.Visible = false;
            groupBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox7.Visible = true;
            groupBox8.Visible = false;
            groupBox3.Visible = false;
            groupBox9.Visible = false;
           
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            colaboracao.AddColaboracao(Convert.ToInt32(idanimador.Value), Convert.ToInt32(nrevento.Value));

           
            listBox2.DataSource = colaboracao.GetColaboracao();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Evento ev = (Evento)listBox1.SelectedItem;
            textBox10.Text = ev.Descricao;
            textBox9.Text = ev.Local;
            textBox6.Text = ev.DataHora;
            textBox5.Text = ev.IdadeInferior;
            textBox14.Text = ev.IdadeSuperior;
            textBox13.Text = ev.LimiteParticipacao;
            textBox4.Text = ev.TipoEvento;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Confirmada = "Confirmado";
            inscricao.AddInscricao(Convert.ToInt32(InscriverNrevento.Value), Convert.ToInt32(InscreverFilho.Value), Confirmada);

            listBox3.DataSource = inscricao.GetInscricao();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           participacao.AddParticipacao(Convert.ToInt32(IdEscola.Value), Convert.ToInt32(nrevento2.Value));


            listBox4.DataSource = participacao.GetParticipacao();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var evento1 = (Evento)listBox1.SelectedItem;

            var id = evento1.NrEvento;

            evento.RemoverEvento(Convert.ToInt32(id));

            listBox1.DataSource = evento.GetEvento();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var evento1 = (Evento)listBox1.SelectedItem;

            var id = evento1.NrEvento;

            evento.AtualizarEvento(Convert.ToInt32(id), textBox10.Text, textBox9.Text, textBox6.Text, textBox5.Text, textBox14.Text, textBox13.Text, textBox4.Text);

            listBox1.DataSource = evento.GetEvento(); 
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
