using System.Collections.Generic;

namespace Course8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();

            lista.Add("Felipe");
            lista.Add("Cacau");
            lista.Add("Rock");
            lista.Add("Geovanna");

            lista.Insert(2, "Dudinha");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista Count: " + lista.Count);

            string s1 = lista.Find(x => x[0] == 'C');

            Console.WriteLine("First: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'F');

            Console.WriteLine("Last: " + s2);

            int s3 = lista.FindIndex(x => x[0] == 'G');
            Console.WriteLine("Primeiro elemento: " + s3);

            int s4 = lista.FindLastIndex(x => x[0] == 'K');
            Console.WriteLine("Ultimo elemento: " + s4);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------------------");

            foreach (var obj in lista2)
            {
                Console.WriteLine(obj);
            }

            lista.Remove("Felipee");
            Console.WriteLine("-----------------------------------");
            foreach (var obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAll(x => x[0] == 'G');
            Console.WriteLine("-----------------------------------");
            foreach (var obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveAt(2);
            Console.WriteLine("-----------------------------------");
            foreach (var obj in lista)
            {
                Console.WriteLine(obj);
            }

            lista.RemoveRange(1, 2);
            Console.WriteLine("-----------------------------------");
            foreach (var obj in lista)
            {
                Console.WriteLine(obj);
            }





        }
    }
}