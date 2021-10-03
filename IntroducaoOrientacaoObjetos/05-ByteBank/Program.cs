using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente danilo = new Cliente();
            danilo.nome = "Danilo";
            danilo.profissao = "Programador";
            danilo.cpf = "111.111.111-11";

            ContaCorrente conta = new ContaCorrente();
            conta.titular = danilo;
            conta.agencia = 863;
            conta.numero = 863452;
            conta.saldo = 500;

            conta.titular.nome = "Danilo Silva";

            Console.WriteLine(danilo.nome);
            Console.WriteLine(conta.titular.nome);
        }
    }
}
