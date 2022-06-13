namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor");
            double n1 = double.Parse(Console.ReadLine());
            double pi = 3.14159;

            double area = pi * Math.Pow(n1, 2);
            Console.WriteLine($"A = {area}");
            

        }
    }
}