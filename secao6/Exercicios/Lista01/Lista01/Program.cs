using System.Collections.Generic;
using System.Globalization;

namespace Lista01
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Funcionario> lista = new List<Funcionario>();

            Console.Write("Quantos funcionarios voce deseja registrar? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Funcionario {i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                lista.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Entre com o id do Funcionario que vai receber aumento: ");
            int idFuncionario = int.Parse(Console.ReadLine());

            var verifica = lista.Find(x => x.Id == idFuncionario);
            if (verifica != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                verifica.Porcentagem(porcentagem);
            } else
            {
                Console.WriteLine("Esse id de funcionario nao existe!");
            }
            Console.WriteLine();
            Console.WriteLine("Lista atualizada de Funcionarios!");

            foreach (var obj in lista)
            {
                Console.WriteLine(obj.ToString());
            }

        }
    }
}