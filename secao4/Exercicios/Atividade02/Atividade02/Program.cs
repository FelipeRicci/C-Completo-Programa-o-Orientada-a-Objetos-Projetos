using System.Globalization;

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario p1 = new Funcionario();
            Funcionario p2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionario:");
            Console.Write("Informe nome do 1º Funcionario: ");
            p1.Nome = Console.ReadLine();

            Console.Write("Informe o Salario do 1º Funcionario: ");
            p1.Salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda Pessoa:");
            Console.Write("Informe nome do 2º Funcionario: ");
            p2.Nome = Console.ReadLine();

            Console.Write("Informe o Salario do 2º Funcionario: ");
            p2.Salario = int.Parse(Console.ReadLine());

            double medio = (p1.Salario + p2.Salario) / 2;
            Console.Write($"Salario Medio = {medio.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}