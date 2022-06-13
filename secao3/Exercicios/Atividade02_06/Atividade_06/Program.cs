using System.Globalization;

namespace Atividade_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            double valor = double.Parse(Console.ReadLine());

            if (valor < 0)
            {
                Console.WriteLine("Fora de Intervalo");
            } else if (valor <= 25)
            {
                Console.WriteLine("Intervalo [0, 25]");
            } else if (valor <= 50)
            {
                Console.WriteLine("Intervalo [25, 50]");
            } else if (valor <= 75)
            {
                Console.WriteLine("Intervalo [50, 75]");
            } else
            {
                Console.WriteLine("Intervalo [75, 100]");
            }
        }
    }
}