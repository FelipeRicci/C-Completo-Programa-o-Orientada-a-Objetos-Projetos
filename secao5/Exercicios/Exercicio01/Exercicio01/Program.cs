using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;
            
            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());

            if (opcao == 's' || opcao == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c1 = new Conta(numero, nome, saldo);
                Console.WriteLine();
            } else
            {
                c1 = new Conta(numero, nome);
            }

            Console.Write("Dados da Conta: \n" + c1);

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(valor);

            Console.WriteLine();
            Console.Write("Dados da Conta Atualizado: \n" + c1);

            Console.Write("Entre um valor para Saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);

            Console.WriteLine();
            Console.Write("Dados da Conta Atualizado: \n" + c1);
        }
    }
}