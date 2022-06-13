namespace Atividade_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a hora inicial");
            int horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a hora final");
            int horaFinal = int.Parse(Console.ReadLine());

            int duracao = 0;

            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            } else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O Jogo durou {duracao} Horas");
        }
    }
}