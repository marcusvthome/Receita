using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloReceita.Text;
            string nomeAutor = txtNomeAutor.Text;
            string receita = rtxtReceita.Text; //vai se transformar em um vetor e leremos linha por linha     
            Arquivo.criarArquivo(titulo, nomeAutor, receita);
            MessageBox.Show("Receita Salva");     
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             Form2 f = new Form2();
            f.ShowDialog();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            string titulo = txtTituloReceita.Text;
            string tituloNovo = txtNomeAutor.Text;
            //Arquivo.apagarArquivo(titulo, tituloNovo);

        }
    }
}
