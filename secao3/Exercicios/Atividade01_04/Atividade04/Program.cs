using System.Globalization;

namespace Atividade04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero do funcionario");
            int numeroFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas");
            int qtdHorasTrabalhada = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o valor recebido por hora");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calcularSalario = qtdHorasTrabalhada * valorHora;

            Console.WriteLine($"Number = {numeroFuncionario}\nSalary = U$ {calcularSalario.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}