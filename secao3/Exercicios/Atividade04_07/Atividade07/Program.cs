using System.Globalization;

namespace Atividade04_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i , 2)} {Math.Pow(i, 3)}");
            }


        }
    }
}