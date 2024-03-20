using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QtdLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (System.Exception)
            {
                return (false, Array.Empty<string>(), 0);
            }
        }
    }
}