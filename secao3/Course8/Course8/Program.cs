namespace Course8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos numero inteiro voce vai digitar ?");
            int numeros = int.Parse(Console.ReadLine());
            int soma = 0;

            for (int i = 0; i < numeros; i++)
            {
                Console.WriteLine("Informe os valores");
                int valores = int.Parse(Console.ReadLine());
                soma += valores;
            }

            Console.WriteLine($"Soma é {soma}");
        }
    }
}