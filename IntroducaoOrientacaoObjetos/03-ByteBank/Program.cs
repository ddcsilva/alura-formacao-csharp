using System;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";
            contaDoDanilo.agencia = 863;
            contaDoDanilo.numero = 863452;

            ContaCorrente contaDoDaniloSilva = new ContaCorrente();
            contaDoDaniloSilva.titular = "Danilo";
            contaDoDaniloSilva.agencia = 863;
            contaDoDaniloSilva.numero = 863452;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoDanilo == contaDoDaniloSilva));

            int idade = 30;
            int idade2 = 30;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idade2));

            contaDoDanilo = contaDoDaniloSilva;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDoDanilo == contaDoDaniloSilva));

            contaDoDanilo.saldo = 500;

            Console.WriteLine(contaDoDanilo.saldo);
            Console.WriteLine(contaDoDaniloSilva.saldo);
        }
    }
}
