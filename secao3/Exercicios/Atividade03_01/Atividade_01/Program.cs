using System.Globalization;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma senha");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Senha Invalida!");
                Console.WriteLine("Informe outra senha");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido!");

        }
    }
}