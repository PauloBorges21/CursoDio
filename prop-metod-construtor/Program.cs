using prop_metod_construtor.Models;


Pessoa p1 = new Pessoa(nome:"Paulo",sobrenome:"Borges");
// p1.Idade = 10;
// p1.Apresentar();
Pessoa p2 = new Pessoa(nome:"Pedro" , sobrenome:"Souza");

Curso c = new Curso();
c.Nome = "Matematica";
c.Alunos = new List<Pessoa>();
c.AdicionarAluno(p1);
c.AdicionarAluno(p2);
c.ListarAlunos();
c.RemoverAluno(p1);
c.ListarAlunos();