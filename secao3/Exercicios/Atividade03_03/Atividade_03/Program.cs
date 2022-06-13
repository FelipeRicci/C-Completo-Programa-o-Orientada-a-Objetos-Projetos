using System.Globalization;

namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o codigo de um produto onde \n1 - Álcool\n2 - Gasolina\n3 - Diesel\n4 - Fim");
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo != 4)
            {
                if (codigo == 1)
                {
                    alcool++;
                } else if (codigo == 2)
                {
                    gasolina++;
                } else if (codigo == 3)
                {
                    diesel++;
                } else
                {
                    Console.Write("");
                }


                Console.WriteLine("Informe um novo Codigo");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}