using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //sbyte x = 100;
            //byte n1 = 255;
            Console.Write("bom dia!");
            Console.WriteLine("boa tarde!");
            Console.WriteLine("boa noite!");

            Console.WriteLine("---------------------------------");

            char genero = 'F';
            int idade = 23;
            double saldo = 10.35785;
            string nome = "Felipe";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("---------------------------------");

            Console.WriteLine("{0} tem {1} anos de idade e tem saldo igual a R${2:F2}", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos de idade e tem saldo igual a R${saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine(nome + " tem " + idade + " anos de idade e tem saldo igual a R$" + saldo.ToString("F2", CultureInfo.InvariantCulture));
        
        }
    }
}