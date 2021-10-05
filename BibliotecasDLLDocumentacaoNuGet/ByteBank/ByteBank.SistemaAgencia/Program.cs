using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(847, 489754);
            conta.Sacar(100);
            
            System.Console.WriteLine(conta.Numero);
        }
    }
}
