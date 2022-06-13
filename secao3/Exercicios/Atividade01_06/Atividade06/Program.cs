using System.Globalization;

namespace Atividade06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o valor de A");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor de B");
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Informe o valor de C");
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double triangulo = (a * c) / 2;
            double circulo = Math.Pow(c, 2) * pi;
            double trapezio = ((a + b) / 2) * c;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine($"Triangulo = {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo = {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio = {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado = {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo = {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");

        
        }
    }
}