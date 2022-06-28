using System.Globalization;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma entrada: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] p = new Produto[n];
            double media = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o nome do Produto");
                string nome = Console.ReadLine();

                Console.WriteLine("Informe o valor do Produto");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Produto { Nome = nome, Preco = preco };

                media += p[i].Preco;
            }

            double avg = media / n;
            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}