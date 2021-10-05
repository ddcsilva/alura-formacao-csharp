using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array de inteiros com 5 posições
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;

            Console.WriteLine(idades[4]);
        }
    }
}
