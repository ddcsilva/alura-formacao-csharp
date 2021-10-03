using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente danilo = new Cliente();

            danilo.nome = "Danilo";
            danilo.profissao = "Programador";
            danilo.cpf = "111.111.111-11";

            conta.Saldo = -10;
            conta.Titular = danilo;

            Console.WriteLine(conta.Titular.nome);
            Console.WriteLine(conta.Saldo);

        }
    }
}
