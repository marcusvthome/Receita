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
            DataGridInterface();

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            ListaReceitas = Arquivo.CarregarArquivos(Rota, ListaArquivos, ListaReceitas);
            DataGridInterface();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
         
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
            DataGridInterface();
        }

        private void DataGridInterface()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ListaReceitas;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].FillWeight = 50;
            dataGridView1.Columns[1].FillWeight = 50;
        }

        private void btnExcluirReceita_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count > 0)
            {

                if (dataGridView1.CurrentRow.Cells[0] == null || ListaReceitas.Count == 0)
                {
                    throw new Exception("Não há itens para excluir!");
                }
                else
                {
                    TituloReceita = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();

                    foreach (Receita receita in ListaReceitas)
                    {
                        if (receita.Titulo == TituloReceita)
                        {
                            DialogResult resposta = MessageBox.Show($"Deseja realmente remover a receita '{receita.Titulo}' do sistema?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (resposta == DialogResult.Yes)
                            {
                                Arquivo.ExcluirArquivo(receita);
                                ListaReceitas.Remove(receita);
                                DataGridInterface();
                                break;
                            }
                        }

                    }
                }

                

            }
            else
                MessageBox.Show("Selecione uma receita para excluir!");
        }
    }
}
