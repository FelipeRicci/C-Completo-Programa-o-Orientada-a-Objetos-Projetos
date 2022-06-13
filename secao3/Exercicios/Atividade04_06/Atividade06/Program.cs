using System.Globalization;

namespace Atividade04_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());

            for (int i = 1; i <= valor; i++)
            {
                if (valor % i == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}