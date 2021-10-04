namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }

        public Diretor(string cpf) : base(5000, cpf)
        {
            System.Console.WriteLine("Criando DIRETOR");
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
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
