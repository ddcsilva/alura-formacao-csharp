using System;

namespace _13_LacoDeRepeticaoFor3
{
    class Program
    {
        static void Main(String[] args)
        {
            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (coluna > linha)
                    {
                        break;
                    }
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
