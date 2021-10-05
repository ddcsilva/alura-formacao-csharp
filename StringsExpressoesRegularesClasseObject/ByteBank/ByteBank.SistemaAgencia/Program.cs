using Humanizer;
using System;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // pagina?argumentos
            // 012345678

            string url = "pagina?argumentos";

            Console.WriteLine(url);
            string argumentos = url.Substring(7);
            Console.WriteLine(argumentos);
        }
    }
}
