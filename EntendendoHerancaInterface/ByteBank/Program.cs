using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(2000, "546.879.157-20");
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            carlos.Nome = "Carlos";
            gerenciador.Registrar(carlos);

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do Carlos " + carlos.Salario);

            Diretor roberta = new Diretor("454.658.148-3");
            Console.WriteLine(Funcionario.TotalDeFuncionarios);

            roberta.Nome = "Roberta";

            Funcionario robertaTeste = roberta;

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da Roberta " + roberta.Salario);

            Console.WriteLine("Bonificação de uma referência de Diretor: " + roberta.GetBonificacao());
            Console.WriteLine("Bonificação de uma referência de Funcionario: " + robertaTeste.GetBonificacao());

            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine("Total de Bonificações: " + gerenciador.GetTotalBonificacao());
        }
    }
}
