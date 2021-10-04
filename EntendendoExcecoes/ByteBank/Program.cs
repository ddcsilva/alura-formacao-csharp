using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(7480, 897845);

            Console.WriteLine(ContaCorrente.TaxaOperacao);
        }
    }
}
