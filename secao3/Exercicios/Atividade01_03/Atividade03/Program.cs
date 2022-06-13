namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 3º valor");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 4º valor");
            int n4 = int.Parse(Console.ReadLine());

            int diferenca = (n1 * n2) - (n3 * n4);
            Console.WriteLine($"Diferença = {diferenca}");


        }
    }
}