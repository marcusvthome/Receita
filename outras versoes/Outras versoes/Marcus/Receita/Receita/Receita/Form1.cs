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
        public List<Receita> dados = new List<Receita>();
        //private List<Receita> listaDados;
        string rota = @"C:\dados";
        List<string> diretorioArquivos = new();

        


    public void GetFiles(string rota)
        {

            if (!Directory.Exists(rota))
            {
                DirectoryInfo di = Directory.CreateDirectory(rota);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(rota));
            }
            var arquivos = Directory.GetFiles(rota);
            foreach (string arquivo in arquivos)
            {
                diretorioArquivos.Add(arquivo);
            }



        }


        public void CarregarArquivos(string rota)
        {
            //string path = $"{endereco.Replace(" ", "")}.txt";
            for (int i = 0;i < diretorioArquivos.Count; i++)
            {
                string path = diretorioArquivos[i];
                StreamReader arquivo = new StreamReader(path);
                string linha;
                string[] sReceita;

                while ((linha = arquivo.ReadLine()) != null)
                {
                    sReceita = linha.Split(";");
                    dataGridView1.Rows.Add(sReceita);
                }
            }
            
        }


        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void bntInserir_Click(object sender, EventArgs e)
        {
            FormInsercao f = new FormInsercao();
            f.Show();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
           
        }

        private void FormPrincipal_Load_1(object sender, EventArgs e)
        {
            
                GetFiles(rota);
                CarregarArquivos(rota);
            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            GetFiles(rota);
            CarregarArquivos(rota);
        }
    }
}
