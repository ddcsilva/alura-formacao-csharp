namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - Funcionário
        // 1 - Diretor
        // 2 - Design
        // 3 - Gerente de Conta Corrente
        // 4 - Coordenador
        // N - ...
        private int _tipo;

        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }

        public double GetBonificacao()
        {
            if (_tipo == 1)
                return Salario;

            return Salario * 0.10;
        }
    }
}
