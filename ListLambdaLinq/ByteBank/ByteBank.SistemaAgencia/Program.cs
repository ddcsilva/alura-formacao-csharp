using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(341, 1),
                new ContaCorrente(342, 999),
                null,
                new ContaCorrente(340, 4),
                new ContaCorrente(340, 456),
                new ContaCorrente(340, 10),
                null,
                null,
                new ContaCorrente(290, 123)
            };

            // contas.Sort(); ~~> Chamar a implementação dada em IComparable

            // contas.Sort(new ComparadorContaCorrentePorAgencia());

            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                contas.OrderBy(conta => {
                    if (conta == null)
                    {
                        return int.MinValue;
                    }

                    return conta.Numero;
                });

            foreach (var conta in contasOrdenadas)
            {
                if (conta != null)
                {
                    Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
                }
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }
        }

        static void TestaListaDeContaCorrente()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
            };

            lista.AdicionarVarios(contas);

            lista.AdicionarVarios(
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            );

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }



        static void TestaArrayDeContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
                {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
                };

            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }
        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 posições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idades no índice {indice}");
                Console.WriteLine($"Valor de idades[{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;
            Console.WriteLine($"Média de idades = {media}");
        }

    }
}
