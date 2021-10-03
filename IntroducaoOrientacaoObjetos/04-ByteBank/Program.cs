using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";

            Console.WriteLine("Saldo Inicial: " + contaDoDanilo.saldo);
            bool resultadoSaque = contaDoDanilo.Sacar(500);

            Console.WriteLine("Resultado do Saque: " + resultadoSaque);
            Console.WriteLine("Após Saque: " + contaDoDanilo.saldo);

            contaDoDanilo.Depositar(500);
            Console.WriteLine("Após Depósito: " + contaDoDanilo.saldo);
        }
    }
}
