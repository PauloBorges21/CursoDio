using prop_metod_construtor.Models;


Pessoa p1 = new Pessoa();

p1.Nome = "Paulo";
p1.Sobrenome = "Borges";


// p1.Idade = 10;

// p1.Apresentar();

Pessoa p2 = new Pessoa();
Curso c = new Curso();
p2.Nome = "Pedro";
p2.Sobrenome = "Souza";

c.Nome = "Matematica";

c.Alunos = new List<Pessoa>();

c.AdicionarAluno(p1);
c.AdicionarAluno(p2);

c.ListarAlunos();

c.RemoverAluno(p1);
c.ListarAlunos();