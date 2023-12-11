// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Array

int[] arrayInteiro = new int[3];

arrayInteiro[0] = 1;
arrayInteiro[1] = 24; 
arrayInteiro[2] = 99;


// Array.Resize(ref arrayInteiro,arrayInteiro.Length * 2);
// Console.WriteLine($"Tamanho do array {arrayInteiro.Length}");

// Copy

// int[] arrayDobrado = new int[arrayInteiro.Length * 2];

// Array.Copy(arrayInteiro, arrayDobrado, arrayInteiro.Length);

// for(int i = 0; i <= arrayInteiro.Length; i++)
// {
//     Console.WriteLine($" Posição Nº {i} - {arrayInteiro[i]}");
// }

int[] arrayInteiro2 = { 1, 22, 33, 44, 55 };

foreach (var item in arrayInteiro2.Select((value, index) => new { value, index }))
{
    Console.WriteLine($"Posição Nº {item.index} - {item.value}");
}

// LIST seria uma extensão de um array

List<string> listString = new List<string>();

listString.Add("SP");
listString.Add("BA");
listString.Add("RJ");    
listString.Add("SC");   

listString.Remove("BA");
for(int contador = 0; contador < listString.Count; contador++)
{
    Console.WriteLine($"Posição Nº{contador} - {listString[contador]}" );
}

int contadorForeach = 0; 
foreach (var item in listString)
{
     Console.WriteLine($"Posição Nº{contadorForeach + 1} - {item}" );
     contadorForeach++;
}