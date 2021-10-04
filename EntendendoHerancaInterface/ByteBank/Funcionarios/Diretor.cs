using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public class Diretor : Autenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            System.Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
