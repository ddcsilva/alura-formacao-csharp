using System;

namespace _12_LacoDeRepeticaoFor2
{
    class Program
    {
        static void Main(String[] args)
        {
            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 0; contador <= 10; contador++)
                {
                    Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
