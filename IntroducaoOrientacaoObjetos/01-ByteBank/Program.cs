using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";
            contaDoDanilo.agencia = 863;
            contaDoDanilo.numero = 863452;
            contaDoDanilo.saldo = 100;

            Console.WriteLine(contaDoDanilo.titular);
            Console.WriteLine("Agência: " + contaDoDanilo.agencia);
            Console.WriteLine("Número: " + contaDoDanilo.numero);
            Console.WriteLine("Saldo: " + contaDoDanilo.saldo);

            contaDoDanilo.saldo += 200;

            Console.WriteLine("Saldo: " + contaDoDanilo.saldo);
        }
    }
}
