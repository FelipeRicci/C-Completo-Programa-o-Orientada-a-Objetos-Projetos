namespace Matriz02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro: ");
            string[] valores = Console.ReadLine().Split(' ');
            int n = int.Parse(valores[0]);
            int m = int.Parse(valores[1]);

            int[,] mat = new int[n, m];
            for (int i =0; i < n; i++)
            {
                string[] matriz = Console.ReadLine().Split(' ');

                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(matriz[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Informe um valor que deseja encontrar: ");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (n1 == mat[i, j])
                    {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        } 
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        } 
                        if (j < m - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < n - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}