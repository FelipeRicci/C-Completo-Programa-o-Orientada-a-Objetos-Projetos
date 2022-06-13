using System.Globalization;

namespace Atividade_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 == 0 && valor2 == 0)
            {
                Console.WriteLine("Origem");
            } else if (valor1 > 0 && valor2 > 0)
            {
                Console.WriteLine("Q1");
            } else if (valor1 > 0 && valor2 < 0)
            {
                Console.WriteLine("Q4");
            } else if (valor1 < 0 && valor2 > 0)
            {
                Console.WriteLine("Q3");
            } else
            {
                Console.WriteLine("Q2");
            }

        }
    }
}