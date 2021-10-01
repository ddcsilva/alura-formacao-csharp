using System;

namespace _02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";

            Console.WriteLine(contaDoDanilo.titular);
            Console.WriteLine("Agência: " + contaDoDanilo.agencia);
            Console.WriteLine("Número: " + contaDoDanilo.numero);
            Console.WriteLine("Saldo: " + contaDoDanilo.saldo);
        }
    }
}
