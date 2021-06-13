using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receita
{
    public abstract class Arquivo
    {
        public List<string> listaArquivos = new();
        public static void CriarArquivo(Receita receita)
        {
            string path = @"C:\dados\" + $"{ receita.Titulo.Replace(" ", "")}.txt"; //nome arquivo salvo
            receita.DataCriacao = DateTime.Today;
            receita.DataAtualizacao = DateTime.Today;

            string[] vReceita = { $"{receita.Titulo}", $"{receita.NomeAutor}", $"{receita.DataCriacao}", $"{receita.DataAtualizacao}", $"{receita.TextoReceita}" };
            File.WriteAllLines($"{path}", vReceita);

        }

        public void CarregarArquivos(string rota)
        {
            Receita teste = new Receita();
            string[] sReceita;
            //string path = $"{endereco.Replace(" ", "")}.txt";
            for (int i = 0; i < listaArquivos.Count; i++)
            {

                string path = listaArquivos[i];
                StreamReader arquivo = new StreamReader(path);

                //sReceita = File.ReadAllText(path, Encoding.Default).Split("\r\n");

                sReceita = File.ReadAllLines(path, Encoding.Default);
                teste.Titulo = sReceita[0];
                teste.NomeAutor = sReceita[1];
                teste.DataCriacao = DateTime.Parse(sReceita[2]);
                teste.DataAtualizacao = DateTime.Parse(sReceita[3]);
                for (int j = 4; j < sReceita.Length; j++)
                {
                    sReceita[j] += ("\n");
                    teste.TextoReceita += sReceita[j];

                }

                MessageBox.Show(teste.TextoReceita);


            }

        }

    }
}
