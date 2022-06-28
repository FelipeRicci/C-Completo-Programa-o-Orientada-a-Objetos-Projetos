namespace Matriz03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = Console.ReadLine().Split(' ');
            int n = int.Parse(lines[0]);
            int m = int.Parse(lines[1]);

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            Console.WriteLine();
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mat[i,j] == x)
                    {
                        Console.WriteLine("Position " + i + "," + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i -1, j]);
                        }
                        if (j < m - 1)
                        {
                            Console.WriteLine("Righ: " + mat[i, j + 1]);
                        }
                        if (i < n - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}