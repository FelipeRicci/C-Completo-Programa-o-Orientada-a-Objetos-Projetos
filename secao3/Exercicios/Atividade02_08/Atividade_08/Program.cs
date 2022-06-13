using System.Globalization;

namespace Atividade_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu Salario");
            double salario = double.Parse(Console.ReadLine());

            double imposto = 0;

            if (salario < 2000)
            {
                Console.WriteLine("Isento");
            } else if (salario <= 3000 )
            {
                imposto = (salario - 2000 ) * 0.08;
            } else if ( salario <= 4500 )
            {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            } else
            {
                imposto = (salario - 4500) * 0.028 + 1500 * 0.18 + 1000 * 0.08;
            }

            Console.WriteLine("R$ " + imposto);
            
        }
    }
}