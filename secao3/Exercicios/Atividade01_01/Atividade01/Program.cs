namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor");
            int n1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Informe o 2º valor");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;
            Console.WriteLine($"O valor é: {soma}");

        }
    }
}