using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receita
{
    public abstract class Arquivo
    {
        
        public static void CriarArquivo(Receita receita)
        {
            string path = @"C:\dados\" + $"{ receita.Titulo.Replace(" ", "")}.txt"; //nome arquivo salvo
            receita.DataCriacao = DateTime.Today;
            receita.DataAtualizacao = DateTime.Today;

            string[] vReceita = { $"{receita.Titulo}", $"{receita.NomeAutor}", $"{receita.DataCriacao}", $"{receita.DataAtualizacao}", $"{receita.TextoReceita}"};
            //File.WriteLine($"{path}", vReceita);
            string linha = vReceita[0] + ";" + vReceita[1] + ";" + vReceita[2] + ";" + vReceita[3] + ";" + vReceita[4] + ";";
            File.WriteAllText($"{path}", linha);
            //StreamReader sr = new StreamReader(path);
           // string rNomeReceita = sr.ReadLine();
            //string rNomeAutor = sr.ReadLine();

        }

    }
}
