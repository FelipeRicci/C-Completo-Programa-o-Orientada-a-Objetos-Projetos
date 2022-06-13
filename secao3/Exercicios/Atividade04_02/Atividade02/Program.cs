namespace Atividade04_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());
            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < valor; i++)
            {
                Console.WriteLine("Informe o valor que deseja verificar se está entre [10, 20]");
                int valor2 = int.Parse(Console.ReadLine());
                if (valor2 >= 10 && valor2 <= 20)
                {
                    dentro++;
                } else
                {
                    fora++;
                }
            }

            Console.WriteLine($"in {dentro}\nout {fora}");
        }
    }
}