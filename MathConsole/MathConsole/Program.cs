using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            int timesFifty = userNum * 50;
            Console.WriteLine("Your number times fifty is " + timesFifty.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter a new number: ");
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int plusTwentyFive = userNum2 + 25;
            Console.WriteLine("Your number plus 25 is " + plusTwentyFive.ToString());
            Console.ReadLine();

            Console.WriteLine("And another number: ");
            double userNum3 = Convert.ToInt32(Console.ReadLine());
            double divByTwlve = userNum3 / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + divByTwlve.ToString());
            Console.ReadLine();

            Console.WriteLine("Enter to see if your number is larger than 50: ");
            int userNum4 = Convert.ToInt32(Console.ReadLine());
            bool trueOrFalse = userNum4 > 50;
            Console.Write(trueOrFalse.ToString());
            Console.ReadLine();

            Console.WriteLine("Finally see your remainder after dividing by seven: ");
            double userNum5 = Convert.ToInt32(Console.ReadLine());
            double divBySeven = userNum5 % 7;
            Console.WriteLine("the remainder is: " + divBySeven.ToString());
            Console.ReadLine();
        }
    }
}
