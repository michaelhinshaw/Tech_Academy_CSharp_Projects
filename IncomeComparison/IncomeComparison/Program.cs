using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Enter your hourly rate");
            double hourlyRate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week");
            double hoursWeek1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Enter your hourly rate");
            double hourlyRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Hours worked per week");
            double hoursWeek2 = Convert.ToInt32(Console.ReadLine());
            
            // I gave everyone a two week vacation

            double salary1 = hourlyRate1 * (hoursWeek1 * 50);
            Console.WriteLine("Annual Salary of Person 1: \n" + salary1.ToString());
            Console.ReadLine();

            // again times 50 because of a two week vacation

            double salary2 = hourlyRate2 * (hoursWeek2 * 50);
            Console.WriteLine("Annual Salary of Person 2: \n" + salary2.ToString());
            Console.ReadLine();

            bool isMore = salary1 > salary2;
            Console.Write("Does Person 1 make more money than Person 2?\n" +isMore.ToString());
            Console.ReadLine();



        }
    }
}
