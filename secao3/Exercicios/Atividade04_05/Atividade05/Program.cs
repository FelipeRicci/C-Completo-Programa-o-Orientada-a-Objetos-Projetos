using System.Globalization;

namespace Atividade04_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());
            double soma = 1;

            for (int i = 1; i <= valor; i++)
            {
                soma = soma * i;
            }
            Console.WriteLine(soma);


        }
    }
}