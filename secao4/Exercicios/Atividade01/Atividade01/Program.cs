namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira Pessoa:");
            Console.Write("Informe nome da 1º Pessoa: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Informe a idade da 1º Pessoa: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa:");
            Console.Write("Informe nome da 2º Pessoa: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Informe a idade da 2º Pessoa: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.Write($"Pessoa mais velha é: {p1.Nome}");
            }
            else
            {
                Console.Write($"Pessoa mais velha é: {p2.Nome}");
            }
        }
    }
}