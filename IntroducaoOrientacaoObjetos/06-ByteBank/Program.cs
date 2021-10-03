using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente danilo = new Cliente();

            danilo.Nome = "Danilo";
            danilo.Profissao = "Programador";
            danilo.CPF = "111.111.111-11";

            conta.Saldo = -10;
            conta.Titular = danilo;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);

        }
    }
}
