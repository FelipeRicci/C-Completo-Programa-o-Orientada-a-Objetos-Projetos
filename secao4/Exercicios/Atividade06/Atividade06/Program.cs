using System.Globalization;

namespace Ativiade06
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            Console.Write("Nome do Aluno: ");
            a.nome = Console.ReadLine();

            Console.WriteLine("Informe as três notas do aluno: ");
            a.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a.media();
        }
    }
}