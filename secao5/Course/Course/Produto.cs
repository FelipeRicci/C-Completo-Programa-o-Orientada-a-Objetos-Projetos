using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5; //Opcional, pois valores inteiro ja começa em -> 0 <-
        }

        public Produto()
        {

        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public void AdicionarProdutos(int qtd)
        {
            Quantidade += qtd;
            Console.WriteLine(Quantidade);
        }

        public void RemoverProdutos(int qtd)
        {
            Quantidade -= qtd;
            Console.WriteLine(Quantidade);
        }

        public override string ToString()
        {
            return _nome + ", R$ " +
                   Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
                   Quantidade + " unidades, Total: R$ " +
                   ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
