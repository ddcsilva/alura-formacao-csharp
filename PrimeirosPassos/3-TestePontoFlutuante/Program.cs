using System;

namespace _3_TestePontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 1250.70;

            Console.WriteLine(salario);

            // int valor = 12.5;             // não compila.

            // int valor2 = 0.0;             // não compila.

            double teste = 125.50;           // compila

            // int valor3 = teste;           // não compila.

            Console.WriteLine(teste);

            int divisao = 5 / 2;
            Console.WriteLine(divisao);

            double divisao2 = 5.0 / 2;
            Console.WriteLine(divisao2);
        }
    }
}
