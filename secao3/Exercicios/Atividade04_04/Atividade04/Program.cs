using System.Globalization;

namespace Atividade04_04
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

                if (b == 0)
                {
                    Console.WriteLine("Divisao Impossivel");
                } else
                {
                    double soma = a / b;
                    Console.WriteLine($"{soma.ToString("F1", CultureInfo.InvariantCulture)}");
                }

            }


        }
    }
}