using System;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cliente danilo = new Cliente();
            // danilo.nome = "Danilo";
            // danilo.profissao = "Programador";
            // danilo.cpf = "111.111.111-11";

            ContaCorrente conta = new ContaCorrente();
            // conta.titular = danilo;
            // conta.titular = new Cliente();
            // conta.titular.nome = "Danilo Silva";
            // conta.titular.cpf = "111.111.111-11";
            // conta.titular.profissao = "Programador";

            conta.agencia = 863;
            conta.numero = 863452;
            conta.saldo = 500;

            if (conta.titular == null)
            {
                Console.WriteLine("Ops, a referência em conta titular é NULA!");
            }

            // Console.WriteLine(danilo.nome);
            Console.WriteLine(conta.titular);
            // Console.WriteLine(conta.titular.nome);
            // Console.WriteLine(conta.titular.cpf);
            // Console.WriteLine(conta.titular.profissao);
        }
    }
}
