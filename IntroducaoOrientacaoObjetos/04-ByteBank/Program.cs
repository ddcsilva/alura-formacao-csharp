using System;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoDanilo = new ContaCorrente();
            contaDoDanilo.titular = "Danilo";

            Console.WriteLine("Saldo Inicial: " + contaDoDanilo.saldo);
            bool resultadoSaque = contaDoDanilo.Sacar(500);

            Console.WriteLine("Resultado do Saque: " + resultadoSaque);
            Console.WriteLine("Após Saque: " + contaDoDanilo.saldo);

            contaDoDanilo.Depositar(500);
            Console.WriteLine("Após Depósito: " + contaDoDanilo.saldo);

            ContaCorrente contaDaRosana = new ContaCorrente();
            contaDaRosana.titular = "Rosana";

            Console.WriteLine("Saldo do Danilo: " + contaDoDanilo.saldo);
            Console.WriteLine("Saldo da Rosana: " + contaDaRosana.saldo);

            bool resultadoTransferencia = contaDoDanilo.Transferir(2000, contaDaRosana);

            Console.WriteLine("Resultado da Transferência: " + resultadoTransferencia);

            Console.WriteLine("Saldo do Danilo: " + contaDoDanilo.saldo);
            Console.WriteLine("Saldo da Rosana: " + contaDaRosana.saldo);

            contaDaRosana.Transferir(100, contaDoDanilo);

            Console.WriteLine("Saldo do Danilo: " + contaDoDanilo.saldo);
            Console.WriteLine("Saldo da Rosana: " + contaDaRosana.saldo);
        }
    }
}
