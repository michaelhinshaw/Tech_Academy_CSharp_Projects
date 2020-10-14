using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report\npress enter to continue.");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page are you on?");
            string pageNum = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNum);
            Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool needsHelp = true;
            string helpStatus = Convert.ToString(needsHelp);
            Console.ReadLine();
            Console.WriteLine("Are there any positive experiences you'd like to share?");
            string expShare = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide?  Please, be specific.");
            string feedBack = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string hrsStudied = Console.ReadLine();
            int studyHours = Convert.ToInt32(hrsStudied);
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers.\nAn instructor will respond to you shortly\nHave a great day");
            Console.ReadLine();
        }
    }
}
