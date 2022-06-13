namespace Course6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maior = {Maior(n1, n2, n3)}");

        }

        static int Maior(int n1, int n2, int n3)
        {
            if (n1 > n2 && n1 > n3)
            {
                return n1;
            }
            else if (n2 > n1 && n2 > n3)
            {
                return n2;
            }
            else
            {
                return n3;
            }
        }
    }
}