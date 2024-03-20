using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tuplas.Models
{
    public class Pessoa
    { }
    // public class Pessoa
//     {
//         // Construtor
//         public Pessoa()
//     {
//     }
//     public Pessoa(string nome, string sobrenome)
//     {
//         Nome = nome;
//         Sobrenome = sobrenome;
//     }

//     public void Desconstruct(out string nome, out string sobrenome)
//     {
//         nome = Nome;
//         sobrenome = Sobrenome;
//     }

//     private string _nome;

//     private int _idade;

//     public string Nome
//     {
//         //Sem Body Expressions
//         //get { return _nome.ToUpper(); }

//         //Com Body Expressions
//         get => _nome.ToUpper();

//         set
//         {
//             if (value == "")
//             {
//                 throw new ArgumentNullException("O nome não pode ser vazio");
//             }
//             _nome = value;
//         }
//     }

//     public int Idade
//     {
//         get => _idade;

//         set
//         {
//             if (value <= 0)
//             {
//                 throw new ArgumentNullException("A idade não pode ser menor que 1");
//             }
//             _idade = value;
//         }

//     }

//     public Pessoa(string sobrenome)
//     {
//         this.Sobrenome = sobrenome;

//     }
//     public Pessoa(string sobrenome)
//     {
//         this.Sobrenome = sobrenome;

//     }
//     public string Sobrenome { get; set; }

//     public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

//     public void Apresentar()
//     {
//         Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
//     }


// }
}