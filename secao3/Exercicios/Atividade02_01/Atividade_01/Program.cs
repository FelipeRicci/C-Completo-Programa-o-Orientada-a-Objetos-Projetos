namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0) {
                Console.WriteLine("NEGATIVO!");
            } else
            {
                Console.WriteLine("NÃO NEGATIVO!");
            }
        }
    }
}