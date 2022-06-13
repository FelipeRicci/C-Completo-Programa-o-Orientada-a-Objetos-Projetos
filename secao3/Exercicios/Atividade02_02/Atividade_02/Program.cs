namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("PAR!");
            }
            else
            {
                Console.WriteLine("IMPAR!");
            }
        }
    }
}