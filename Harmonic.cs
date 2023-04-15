using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int N = Convert.ToInt32(Console.ReadLine());

            if (N == 0)
            {
                Console.WriteLine("Invalid input. N should be a non-zero positive integer.");
                return;
            }

            double harmonicValue = 0;

            for (int i = 1; i <= N; i++)
            {
                harmonicValue += 1.0 / i;
            }

            Console.WriteLine($"The Nth Harmonic Value is: {harmonicValue}");
        }
    }
}
