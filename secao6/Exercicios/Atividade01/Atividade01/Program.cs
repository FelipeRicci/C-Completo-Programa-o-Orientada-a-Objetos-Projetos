namespace Atividade01 { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quarto voce quer reservar? ");
            int n = int.Parse(Console.ReadLine());
            Aluguel[] al = new Aluguel[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nRent #{i} : ");
                Console.Write("Name: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                al[room] = new Aluguel(nome, email);

            }

            Console.WriteLine("Busy Rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (al[i] != null)
                {
                    Console.WriteLine($"#{i} : {al[i]}");
                }
            }
        }
    }
}