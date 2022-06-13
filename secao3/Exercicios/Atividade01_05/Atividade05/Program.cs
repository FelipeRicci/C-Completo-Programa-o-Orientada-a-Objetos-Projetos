using System.Globalization;

namespace Atividade05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero do funcionario");
            string[] s1 = Console.ReadLine().Split(' ');

            Console.WriteLine("Informe o numero do funcionario");
            string[] s2 = Console.ReadLine().Split(' ');

            int codigoPeca1 = int.Parse(s1[0]);
            int numeroPeca1 = int.Parse(s1[1]);
            double valorUnit1 = double.Parse(s1[2], CultureInfo.InvariantCulture);

            int codigoPeca2 = int.Parse(s2[0]);
            int numeroPeca2 = int.Parse(s2[1]);
            double valorUnit2 = double.Parse(s2[2], CultureInfo.InvariantCulture);

            double valorAPagar = (numeroPeca1 * valorUnit1) + (numeroPeca2 * valorUnit2);

            Console.WriteLine($"Valor a pagar = R${valorAPagar.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}