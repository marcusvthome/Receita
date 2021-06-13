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
        public static List<Receita> listaReceitas = new List<Receita>();

        public string rota = @"C:\dados";
        List<string> listaArquivos = new();
        
        public void CaminhoArquivos(string rota)
        {

            if (!Directory.Exists(rota))
            {
                DirectoryInfo di = Directory.CreateDirectory(rota);
            }
            var arquivos = Directory.GetFiles(rota);
            foreach (string arquivo in arquivos)
            {
                listaArquivos.Add(arquivo);
            }
        }

        public void CarregarArquivos(string rota)
        {
            
            string[] sReceita;
            for (int i = 0; i < listaArquivos.Count; i++)
            {
                Receita objeto = new Receita();
                string path = listaArquivos[i];
                StreamReader arquivo = new StreamReader(path);
                sReceita = File.ReadAllLines(path, Encoding.Default);
                objeto.Titulo = sReceita[0];
                objeto.NomeAutor = sReceita[1];
                objeto.DataCriacao = DateTime.Parse(sReceita[2]);
                objeto.DataAtualizacao = DateTime.Parse(sReceita[3]);
                for (int j = 4; j < sReceita.Length; j++)
                {
                    sReceita[j] += ("\n");
                    objeto.TextoReceita += sReceita[j];                
                }
                arquivo.Close();
                listaReceitas.Add(objeto);              
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReceitas;
        }


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            FormInsercao f = new FormInsercao();
            f.Show();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReceitas;
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
           
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {
            
                CaminhoArquivos(rota);
                CarregarArquivos(rota);

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaReceitas;
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormExibeReceita f = new FormExibeReceita();
            f.txtTitulo.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f.txtNomeAutor.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f.txtReceita.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f.Show();
        }
    }
}
