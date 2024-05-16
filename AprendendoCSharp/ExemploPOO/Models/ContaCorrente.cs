using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {

        public int NumeroConta { get; set; }
        private decimal saldo;
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }


        public void SacarConta(decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                System.Console.WriteLine("Saque realizado");
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente");
            }

        }

        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo disponível é " + saldo);
        }
    }
}