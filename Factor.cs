using System;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its prime factors:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Prime factors of {n} are:");
            PrimeFactorization(n);

            Console.ReadLine();
        }

        static void PrimeFactorization(int n)
        {
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write($"{i} ");
                    n = n / i;
                }
            }
        }
    }
}

