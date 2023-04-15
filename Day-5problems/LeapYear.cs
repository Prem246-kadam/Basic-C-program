using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
    internal class LeapYear
    {
        public void leapYear() 
        {
            Console.WriteLine("Enter Year");
            int Year = Convert.ToInt32(Console.ReadLine());

            bool isLeapYear = false;

            if ( Year % 4 == 0 && Year % 100 != 0 )
            {
                isLeapYear = true;
            }
            else
            {
                Console.WriteLine("Given yeat is not leap year");
            }
        }
    }
}
