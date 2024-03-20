// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using VarDinamicoClassesGenericas.Models;
Console.WriteLine("Hello, World!");

dynamic variavelDinamica = 4;
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()} , Valor: {variavelDinamica}");

variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()} , Valor: {variavelDinamica}");

variavelDinamica = true;
Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()} , Valor: {variavelDinamica}");

MeuArray<int> arrayInteiro = new MeuArray<int>();
MeuArray<string> arrayString = new MeuArray<string>();

arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine(arrayInteiro[0]);

arrayString.AdicionarElementoArray("Teste");
Console.WriteLine(arrayString[0]);


int numero = 15; 
bool par = false;
par = numero.EhPar();

string mensagem = "O numero " + numero + " é " + (par ? "par" : "ímpar");

Console.WriteLine(mensagem);