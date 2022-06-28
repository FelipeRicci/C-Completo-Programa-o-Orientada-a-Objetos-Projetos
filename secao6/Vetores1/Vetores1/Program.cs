using System.Globalization;

namespace Vetores1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma entrada: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];
            double media = 0;

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media += vet[i];
            }

            double avg = media / n;
            Console.WriteLine($"AVERAGE HEIGHT = {avg.ToString("F2", CultureInfo.InvariantCulture)}");




        }
    }
}