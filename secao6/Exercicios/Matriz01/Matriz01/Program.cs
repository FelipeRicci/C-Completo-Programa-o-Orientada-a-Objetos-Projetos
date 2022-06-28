namespace Matriz01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inteiro");
            int n = int.Parse(Console.ReadLine());
            int cont = 0;

            int[,] mat = new int[n,n];

            for ( int i = 0; i < n; i++)
            {
                Console.Write("Informe os valores: ");
                string[] valores = Console.ReadLine().Split(' ');

                for ( int j = 0; j < n; j++ )
                {
                    mat[i,j] = int.Parse(valores[j]);
                    if (mat[i, j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n ; i++)
            {
                Console.Write(mat[i,i] + " \n");
            }
            Console.WriteLine("Negative number: " + cont);
        }
    }
}