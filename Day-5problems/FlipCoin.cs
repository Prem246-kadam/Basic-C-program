using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
     class FlipCoin
    {
        public void filpCion()
        {
            Console.WriteLine("Enter the number of times to flip the coin:");
            int numFlips = Convert.ToInt32(Console.ReadLine());

            if (numFlips <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive integer.");
                return;
            }

            int numHeads = 0;
            int numTails = 0;
            Random rand = new Random();

            for (int i = 0; i < numFlips; i++)
            {
                if (rand.NextDouble() < 0.5)
                {
                    numHeads++;
                }
                else
                {
                    numTails++;
                }
            }

            double percentHeads = (double)numHeads / numFlips * 100;
            double percentTails = (double)numTails / numFlips * 100;

            Console.WriteLine("Number of Heads: " + numHeads);
            Console.WriteLine("Number of Tails: " + numTails);
           
        }
    }

}

