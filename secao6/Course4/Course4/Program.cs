namespace Course4
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(10, 7, 2 );
            int s3 = Calculator.Sum(10, 7, 3, 10);

            Console.WriteLine($"S1 {s1}");
            Console.WriteLine($"S2 {s2}");
            Console.WriteLine($"S3 {s3}");
        }
    }
}