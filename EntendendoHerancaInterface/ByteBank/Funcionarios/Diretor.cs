namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            System.Console.WriteLine("Criando DIRETOR");
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
