using System;

namespace PowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N (0 <= N < 31):");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N < 0 || N >= 31)
            {
                Console.WriteLine("Invalid input. N should be in the range of 0 to 30.");
                return;
            }

            Console.WriteLine("Powers of 2:");

            int result = 1;
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine($"2^{i} = {result}");
                result *= 2;
            }
        }
    }
}
