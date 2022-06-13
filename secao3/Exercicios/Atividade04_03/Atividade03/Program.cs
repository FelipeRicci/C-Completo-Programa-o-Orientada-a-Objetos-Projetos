using System.Globalization;

namespace Atividade04_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Informe tres valores");
                string[] valor2 = Console.ReadLine().Split(' ');
                double a = double.Parse(valor2[0], CultureInfo.InvariantCulture);
                double b = double.Parse(valor2[1], CultureInfo.InvariantCulture);
                double c = double.Parse(valor2[2], CultureInfo.InvariantCulture);

                double soma = ((a * 2.0) + (b * 3.0) + (c * 5)) / 10;
                Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
            }

            
        }
    }
}