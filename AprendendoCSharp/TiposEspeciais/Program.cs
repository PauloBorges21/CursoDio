// See https://aka.ms/new-console-template for more information
bool? desejaReceberEmail = null;
desejaReceberEmail = true;
//desejaReceberEmail.HasValue verifica se existe um valor ou seja diferente de nulo
// desejaReceberEmail.Value é o proprio valor
if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuario optou por receber email.");
}
else
{
    Console.WriteLine("O usuario não respondeu ou não optou por receber email.");
}

var tipoAnonimo = new { Nome = "Paulo", Sobrenome = "Borges", Altura = 1.80 };
Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobronome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);