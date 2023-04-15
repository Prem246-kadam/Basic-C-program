using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
    internal class Swap
    {
        public void swapNumbers()
        {
            Console.WriteLine("Enter First num");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            // Use a temparory variable to store
            int temp = a;
             a = b;
             b = temp;
            Console.WriteLine("After Swaping ");
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);

        }
    }
}
