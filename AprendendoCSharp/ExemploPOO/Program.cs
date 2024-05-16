using ExemploPOO.Models;
// See https://aka.ms/new-console-template for more information

// Pessoa p = new Pessoa();

// p.Nome = "Paulo";
// p.Idade = 99;

// p.Apresentar();

ContaCorrente c1 = new ContaCorrente(123,1000);

c1.ExibirSaldo();

c1.SacarConta(5000);

c1.ExibirSaldo();