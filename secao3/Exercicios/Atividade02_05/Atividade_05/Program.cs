using System.Globalization;

namespace Atividade_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o codigo de um item");
            int codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de item");
            int qtdItem = int.Parse(Console.ReadLine());

            double resultado = 0;

            if (codigo == 1)
            {
                resultado = qtdItem * 4;
            } else if (codigo == 2)
            {
                resultado = qtdItem * 4.5;
            } else if (codigo == 3)
            {
                resultado = qtdItem * 5;
            } else if (codigo == 4)
            {
                resultado = qtdItem * 2;
            } else if (codigo == 5)
            {
                resultado = qtdItem * 1.5;
            } else
            {
                Console.WriteLine("Codigo invalido!");
            }

            Console.WriteLine($"Total: R${resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}