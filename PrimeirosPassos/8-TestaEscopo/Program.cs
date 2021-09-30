using System;

namespace _8_TestaEscopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testando Condicionais");

            int idade = 20;
            int quantidadePessoas = 3;
            bool acompanhado;

            if (quantidadePessoas >= 2)
            {
                acompanhado = true;
            }
            else
            {
                acompanhado = false;
            }

            if (idade >= 18 || acompanhado)
            {
                Console.WriteLine("Seja bem vindo");
            }
            else
            {
                Console.WriteLine("infelizmente você não pode entrar");
            }
        }
    }
}
