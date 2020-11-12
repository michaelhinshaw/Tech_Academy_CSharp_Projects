using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");

            // String input variable
            string inputName = Console.ReadLine();

            // add another input
            Console.WriteLine("Where are you from?");

            // string input variable 2
            string fromWhere = Console.ReadLine();

            // add another input
            Console.WriteLine("What is your favorite film?");

            // string variable 3
            string faveFilm = Console.ReadLine();

            inputName = inputName.ToUpper();

            Console.WriteLine("Hello " + inputName + " from " + fromWhere + ".\nIt says here your favorite film is " + faveFilm + ".");
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Michael ");
            sb.AppendLine("My favorite film is ");
            sb.AppendLine("Cinema Paradiso.");
            sb.AppendLine("I really love music, ");
            sb.AppendLine("and the leaves in the fall.");
            Console.WriteLine(sb);
            Console.ReadLine();

            
            
        }
    }
}
