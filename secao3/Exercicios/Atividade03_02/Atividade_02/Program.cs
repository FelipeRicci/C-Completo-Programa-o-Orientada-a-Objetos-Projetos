using System.Globalization;

namespace Atividade_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma posição X e Y");
            string[] posicao = Console.ReadLine().Split(' ');

            int x = int.Parse(posicao[0]);
            int y = int.Parse(posicao[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                } else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quarto");
                } else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                } else
                {
                    Console.WriteLine("Segundo");
                }


                Console.WriteLine("Informe uma posição X e Y");
                posicao = Console.ReadLine().Split(' ');

                x = int.Parse(posicao[0]);
                y = int.Parse(posicao[1]);

            }

            Console.WriteLine("Posição Invalida");

        }
    }
}