using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
     class FindEvenOdd
    {
        public void evenOrOdd()
        {
            Console.WriteLine(" Ente a number ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num%2 == 0) 
            {
                Console.WriteLine(num + "Number is a Even Number");
            }
            else
            {
                Console.WriteLine(num +"Number is a Odd Number");
            }

        }
    }
}
