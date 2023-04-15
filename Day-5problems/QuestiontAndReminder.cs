using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5problems
{
    internal class QuestiontAndReminder
    {
        public void questiontAndReminder()
        {
            Console.WriteLine(" Enter Divident");
            int divident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Divisor");
            int divisor =Convert.ToInt32(Console.ReadLine());

            int Que = divident / divisor;
            int reminder = divident % divisor;
        }
    }
}
