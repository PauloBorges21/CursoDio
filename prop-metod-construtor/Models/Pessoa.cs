using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prop_metod_construtor.Models
{
    public class Pessoa
    {
        private string _nome;

        private int _idade;

        public string Nome
        {
            //Sem Body Expressions
            //get { return _nome.ToUpper(); }

            //Com Body Expressions
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public int Idade
        {
            get => _idade;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("A idade não pode ser menor que 1");
                }
                _idade = value;
            }

        }

        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}