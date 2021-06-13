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
            string path = $"{receita.Titulo.Replace(" ", "")}.txt"; //nome arquivo salvo
            receita.DataCriacao = DateTime.Today;
            receita.DataAtualizacao = DateTime.Today;

            string[] vReceita = { $"{receita.Titulo}", $"{receita.NomeAutor}", $"{receita.DataCriacao}", $"{receita.DataAtualizacao}", $"{receita.TextoReceita}" };
            File.WriteAllLines($"{path}", vReceita);

            StreamReader sr = new StreamReader(path);
            string rNomeReceita = sr.ReadLine();
            string rNomeAutor = sr.ReadLine();

        }

    }
}
