using System.Globalization;

namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string[] s = Console.ReadLine().Split(' ');

            string nome = s[0];
            char sexo = char.Parse(s[1]);
            int idade = int.Parse(s[2]);
            double altura = double.Parse(s[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine($"Nome {s[0]}\n, Sexo {s[1]}\n, Idade{s[2]}\n, Altura {s[3]}");
        }
    }
}