namespace Atividade_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o 1º valor");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o 2º valor");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 % n2 == 0 || n2 % n1 == 0)
            {
                Console.WriteLine("Multiplos!");
            }
            else
            {
                Console.WriteLine("Não são Multiplos!");
            }
        }
    }
}