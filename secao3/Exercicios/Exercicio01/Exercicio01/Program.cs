using System.Globalization;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdQuarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] s = Console.ReadLine().Split(' ');

            string sobreNome = s[0];
            int idade = int.Parse(s[1]);
            double altura = double.Parse(s[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(qtdQuarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobreNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}