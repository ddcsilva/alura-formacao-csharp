using ByteBank.Modelos;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.meuMetodo(numero: 10);

            lista.Adicionar(new ContaCorrente(874, 5648163));
            lista.Adicionar(new ContaCorrente(874, 5648164));
            lista.Adicionar(new ContaCorrente(874, 5648165));
            lista.Adicionar(new ContaCorrente(874, 5648165));
            lista.Adicionar(new ContaCorrente(874, 5648165));
            lista.Adicionar(new ContaCorrente(874, 5648165));
            lista.Adicionar(new ContaCorrente(874, 5648165));
            lista.Adicionar(new ContaCorrente(874, 5648165));
        }

        static void TesteArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5648163),
                new ContaCorrente(874, 5648164),
                new ContaCorrente(874, 5648165)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente conta = contas[i];
                Console.WriteLine($"Conta {i} - {conta.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // Array de inteiros com 6 posições
            int[] idades = new int[6];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;

            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];

                Console.WriteLine($"Acessando o array idades no índice {i}");
                Console.WriteLine($"Valor de idades[{i}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de Idades = {media}");
        }
    }
}
