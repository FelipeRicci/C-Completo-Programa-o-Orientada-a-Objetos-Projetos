using System.Globalization;

namespace Course7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            
            while (n1 >= 0)
            {
                double resultado = Math.Sqrt(n1);
                Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Informe 3 numeros");
                n1 = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Numero Negativo!");

        }
    }
}