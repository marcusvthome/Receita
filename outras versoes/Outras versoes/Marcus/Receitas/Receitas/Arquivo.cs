using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Receitas
{
    public abstract class Arquivo
    {

       /* public static void apagarArquivo(string titulo, string novoTitulo)
        {
            string path = $"{titulo.Replace(" ", "")}.txt"; //nome arquivo salvo
            string tituloAntigo2 = titulo;
            string tituloAntigo = $"{titulo.Replace(" ", "")}bkp.txt";
            string novoTitulo2 = $"{novoTitulo.Replace(" ", "")}.txt";

            foreach (string line in File.ReadLines($"{path}"))
            {
                if (line.Contains($"{tituloAntigo2}"))
                {
                    File.Replace(novoTitulo2, path, tituloAntigo);
                }
            }
        }*/
        public static void criarArquivo(string titulo, string nomeAutor, string receita)
        {
            string path = $"{titulo.Replace(" ", "")}.txt"; //nome arquivo salvo
            string dataCriacao = DateTime.Now.ToString("dd-MM-yyyy");
            string[] vReceita = { $"{titulo}", $"{nomeAutor}", $"{dataCriacao}", $"{receita}" };
            File.WriteAllLines($"{path}", vReceita);

            //string[] y = File.ReadAllLines(path);    fazer um vetor e salvar linha por linha

            StreamReader sr = new StreamReader(path);
            string rNomeReceita = sr.ReadLine();
            string rNomeAutor = sr.ReadLine();

            /*string RNomeReceita = File.ReadLines($"{path}", 1);
            MessageBox.Show("Nome da receita com o metodo de 1 linha é" + RNomeReceita);*/
            MessageBox.Show("Nome da receita com o metodo ruim é " + rNomeReceita); //funciona
        }
    }
}
