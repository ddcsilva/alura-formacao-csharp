namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public double GetBonificacao()
        {
            return Salario;
        }
    }
}
