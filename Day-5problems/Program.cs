namespace Day_5problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Large Number 2.FindEvenOdd 3.LeapYear 4.FlipCoin 5.Swap 6.VowelOrConsonentes 7.QuestiontAndReminder");;

           int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LargeNumber largeNumber = new LargeNumber();
                    largeNumber.largeNum();
                    break;

            case 2:
                    FindEvenOdd findEvenOdd = new FindEvenOdd();
                    findEvenOdd.evenOrOdd();
                    break;
             case 3:
                    LeapYear leapYear = new LeapYear();
                    leapYear.leapYear();
                    break;
            case 4:
                    FlipCoin coin = new FlipCoin();
                    coin.filpCion();    
                    break;

            case 5:
                    Swap swap = new Swap();
                    swap.swapNumbers();
                    break;
            case 6:
                    VowelOrConsonents vowelOrConsonents = new VowelOrConsonents();
                    vowelOrConsonents.check();
                    break;

            case 7:
                    QuestiontAndReminder questiontAndReminder = new QuestiontAndReminder();
                    questiontAndReminder.questiontAndReminder();
                    break;
//
//                   default:
 //                   Console.WriteLine("Please Enter Correct option");


            }
        }
    }
}
