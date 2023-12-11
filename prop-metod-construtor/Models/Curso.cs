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


         void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

    }
}