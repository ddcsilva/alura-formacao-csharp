using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";

            Console.WriteLine(contaDoDanilo.saldo);
            contaDoDanilo.Sacar(50);
            Console.WriteLine(contaDoDanilo.saldo);

            Console.WriteLine(contaDoDanilo.Sacar(500));
        }
    }
}
