using System.Globalization;

namespace ProblemaExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 medidade do triangulo X");
            double X1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double X2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double X3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Informe 3 medidade do triangulo Y");
            double Y1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double Y3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double px = (X1 + X2 + X3) / 2;
            double areaX = Math.Sqrt(px * (px - X1) * (px - X2) * (px - X3));

            double py = (Y1 + Y2 + Y3) / 2;
            double areaY = Math.Sqrt(py * (py - Y1) * (py - Y2) * (py - Y3));

            Console.WriteLine($"Area de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Area de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");
            
            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }
}