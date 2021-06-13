using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receita
{
    public partial class FormPrincipal : FormBase
    {
        public static List<Receita> ListaReceitas = new List<Receita>();
        public string Rota = @"C:\dados";
        List<string> ListaArquivos = new();
        public static string TituloReceita;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            FormInsercao f = new FormInsercao();
            f.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaReceitas;

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ListaReceitas = Arquivo.CarregarArquivos(Rota, ListaArquivos, ListaReceitas);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaReceitas;
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaReceitas;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormExibeReceita f = new FormExibeReceita();
            TituloReceita = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < ListaReceitas.Count; i++)
            {
                if (ListaReceitas[i].Titulo == TituloReceita)
                {                  
                    f.txtTitulo.Text = ListaReceitas[i].Titulo;
                    f.txtNomeAutor.Text = ListaReceitas[i].NomeAutor;
                    string receitaFormatada = ListaReceitas[i].TextoReceita;
                    
                    f.txtReceita.Text = string.Format(receitaFormatada, Environment.NewLine);
                }
            }
            f.ShowDialog();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaReceitas;
        }

        private void btnExcluirReceita_Click(object sender, EventArgs e)
        {

        }
    }
}
