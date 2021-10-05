using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void meuMetodo(string texto = "ABC", int numero = 1)
        {

        }

        public void Adicionar(ContaCorrente item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            System.Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            System.Console.WriteLine("Aumentando capacidade da Lista!");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                System.Console.WriteLine(".");
            }

            _itens = novoArray;
        }
    }
}
