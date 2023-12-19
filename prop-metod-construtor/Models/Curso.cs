using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prop_metod_construtor.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        public List<Pessoa> Alunos { get; set; } 


        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public int QuantidadeAlunoMatriculados()
        {
            int quatidadeAlunos = Alunos.Count;
            return quatidadeAlunos;
        }


        public void ListarAlunos()
        {   
             Console.WriteLine($"Alunos do curso: {Nome}") ;
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"{aluno.NomeCompleto}") ;
            }
            
        }

    }
}