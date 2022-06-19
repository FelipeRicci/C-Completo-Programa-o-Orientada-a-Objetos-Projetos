using System.Globalization;

namespace Atividade07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar: ");
            ConversorDeMoeda.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vao comprar? ");
            ConversorDeMoeda.quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Valor a ser pago em reais = R$ {ConversorDeMoeda.ValorASerPago().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}