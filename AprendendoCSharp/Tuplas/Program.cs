
using Tuplas.Models;
using Newtonsoft.Json;
// LeituraArquivo arquivo = new LeituraArquivo();


// Pessoa p1 = new Pessoa("Paulo","Borges");

// (string nome, string sobrenome) = p1;
List<Venda> listaVenda = new List<Venda>();


DateTime dataAtual = DateTime.Now;
Venda v1 = new Venda(1, "Material", 25.00M, dataAtual, 10.00M);
Venda v2 = new Venda(2, "Material de limpeza", 9.00M, dataAtual, null);
listaVenda.Add(v1);
listaVenda.Add(v2);
string serialized = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

File.AppendAllText("Arquivos/vendas.json", serialized);

// Console.WriteLine($"{serialized}");

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVendasDeserializada = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

//Anônimo em coleção

var listaAnonimo = listaVendasDeserializada.Select(x =>new {x.Produto , x.Preco});

foreach (var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto} , Preco: {venda.Preco}");
}

foreach (Venda venda in listaVendasDeserializada)
{
    Console.WriteLine($"ID: {venda.Id}, Produto: {venda.Produto}, " +
                      $"Preço: {venda.Preco}, " +
                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
                      $" {(venda.Desconto.HasValue ? $", Desconto: {venda.Desconto}" : "")}");
}

// TENARIO
// int numero = 15;
// bool estado = false;

// estado = numero % 2 == 0;

// Console.WriteLine($"O numero: {numero} é " + (estado ? "par" : "ímpar"));

//exemplo de como usar uma tupla por metodo
// var (sucesso, linhasArquivos, quantidadeLinhas) = arquivo.LerArquivo("Arquivoss/arquivoLeitura.txt");

//Exemplo de discarte
// var (sucesso, linhasArquivos, _) = arquivo.LerArquivo("Arquivoss/arquivoLeitura.txt");

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);

//     foreach (string linha in linhasArquivos)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo: ");
// }


//Console.WriteLine("Hello, World!");

// (int ID,string Nome,string Sobrenome,decimal Altura) tupla = (1,"Paulo","Borges",1.70M);

// ValueTuple<int,string,string,decimal> outroExemploTupla = (2,"Paulo","Borges",1.70M);

// var outroExemploTuplaCreate = Tuple.Create(3,"Paulo","Borges",1.70M);

// Console.WriteLine($"ID: {tupla.ID}");
// Console.WriteLine($"Nome: {tupla.Nome}");
// Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");