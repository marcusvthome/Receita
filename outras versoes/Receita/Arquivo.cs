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

        public static void CriarArquivo(Receita Receita)
        {
            string Path = @"C:\dados\" + $"{ Receita.Titulo.Replace(" ", "")}.txt"; //nome Arquivo salvo
            Receita.DataCriacao = DateTime.Today;
            Receita.DataAtualizacao = DateTime.Today;

            string[] vReceita = { $"{Receita.Titulo}", $"{Receita.NomeAutor}", $"{Receita.DataCriacao}", $"{Receita.DataAtualizacao}", $"{Receita.TextoReceita}" };
            File.WriteAllLines($"{Path}", vReceita);

        }

        public static List<Receita> CarregarArquivos(string Rota, List<string> ListaArquivos, List<Receita> ListaReceitas)
        {
            if (!Directory.Exists(Rota))
            {
                DirectoryInfo di = Directory.CreateDirectory(Rota);
            }
            var Arquivos = Directory.GetFiles(Rota);
            foreach (string Arquivo in Arquivos)
            {
                ListaArquivos.Add(Arquivo);
            }

            string[] sReceita;
            for (int i = 0; i < ListaArquivos.Count; i++)
            {
                Receita ObjetoReceita = new Receita();
                string Path = ListaArquivos[i];
                StreamReader Arquivo = new StreamReader(Path);
                sReceita = File.ReadAllLines(Path, Encoding.Default);
                ObjetoReceita.Titulo = sReceita[0];
                ObjetoReceita.NomeAutor = sReceita[1];
                ObjetoReceita.DataCriacao = DateTime.Parse(sReceita[2]);
                ObjetoReceita.DataAtualizacao = DateTime.Parse(sReceita[3]);
                for (int j = 4; j < sReceita.Length; j++)
                {
                    ObjetoReceita.TextoReceita += sReceita[j];
                    ObjetoReceita.TextoReceita += @"{" + $"{0}" + @"}";
                }
                Arquivo.Close();
                ListaReceitas.Add(ObjetoReceita);
            }

            return ListaReceitas;
        }

        public static void AtualizarArquivo(Receita receita, string TituloReceitaAtual)
        {
            string Path = @"C:\dados\" + $"{TituloReceitaAtual.Replace(" ", "")}" + ".txt";
            string NovoNome = @"C:\dados\" + $"{receita.Titulo.Replace(" ", "")}" + ".txt";

            if (File.Exists(Path))
            {
                File.Move(Path, NovoNome);
                StreamWriter fTexto = new StreamWriter(NovoNome);
                fTexto.WriteLine(receita.Titulo);
                fTexto.WriteLine(receita.NomeAutor);
                fTexto.WriteLine(receita.DataCriacao);
                fTexto.WriteLine(receita.DataAtualizacao);
                fTexto.WriteLine(receita.TextoReceita);
                fTexto.Close();
            }
        }

        /*
        public static List<Receita> ExcluirReceita(Receita receita, List<Receita> ListaReceitas)
        {
            //implementar método que exclui receita e devolve a lista sem o objeto e exclui o arquivo
            //da pasta
        }*/
    }
}
