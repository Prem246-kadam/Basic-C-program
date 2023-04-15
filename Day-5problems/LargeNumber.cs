using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
     class LargeNumber
    {
        public void largeNum()
        {
            Console.WriteLine("Enter First number");
            int a =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int b =Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Enter Third Number");
            int c =Convert.ToInt32(Console.ReadLine());

            int Largest = a;
            if (b > Largest)
            {
                Largest = b;
            }
            if (c > Largest)
            {
                Largest = c;
            }
            Console.WriteLine("The Largest Number is " + Largest);

        } 
    }
}
