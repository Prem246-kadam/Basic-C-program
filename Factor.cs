using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its prime factors:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N <= 1)
            {
                Console.WriteLine("Invalid input. N should be greater than 1.");
                return;
            }

            Console.WriteLine($"Prime factors of {N}:");
            int i = 2;

            while (i * i <= N)
            {
                if (N % i == 0)
                {
                    Console.WriteLine(i);
                    N /= i;
                }
                else
                {
                    i++;
                }
            }

            if (N > 1)
            {
                Console.WriteLine(N);
            }
        }
    }
}
