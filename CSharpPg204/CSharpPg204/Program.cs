using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPg204
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArray = {
                "Hello: ",
                "How is your day today, ",
                "What do you want to do today, "
            };




            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += userName;
            }

            // print on separate lines 

            for (int k = 0; k < stringArray.Length; k++)
            {
                Console.WriteLine(stringArray[k]);
            }
            Console.ReadLine();

            //infinite loop

            int j = 0;

            while (true)
            {
                Console.WriteLine("j = {0}", j);
                j++;

                // where I fixed the infinite loop

                if (j > 20)
                    break;
            }
            Console.ReadLine();

            // pg 206 < and <= operator

            Console.WriteLine("Enter a number 20 and below for countdown: ");
            int countdown = Convert.ToInt32(Console.ReadLine());

            while (countdown < 21)
            {
                Console.WriteLine("Launch in {0}", countdown);
                countdown--;

                if (countdown == 0)
                    break;
            }
            Console.ReadLine();

            Console.WriteLine("Enter a number 1-10");
            int upOrDown = Convert.ToInt32(Console.ReadLine());

            while (upOrDown <= 5)
            {
                Console.WriteLine(upOrDown);
                upOrDown--;

                if (upOrDown == 0)
                    break;
            }
            Console.ReadLine();

            if (upOrDown > 5)
            {
                Console.WriteLine("Try Again");
                Console.ReadLine();
            }


            // Console application assignment 4, pg 207, list iteration
            List<string> bikeCities = new List<string>();
            bikeCities.Add("Boulder");
            bikeCities.Add("Portland");
            bikeCities.Add("Austin");
            bikeCities.Add("Fort Collins");
            bikeCities.Add("Madison");
            bikeCities.Add("Brooklyn");
            bikeCities.Add("Santa Monica");

            Console.WriteLine("Search to see if your city is bike friendly:");
            string userCity = Console.ReadLine();


            if (bikeCities.Contains(userCity))
            {
                Console.WriteLine(userCity + " [" + bikeCities.IndexOf(userCity) + "]");
            }
            else
            {
                Console.WriteLine("Your selection is not on the list.");
            }
            Console.ReadLine();

            // assignment 5 need help

            List<string> furnInvent = new List<string>();
            furnInvent.Add("chair");
            furnInvent.Add("lamp");
            furnInvent.Add("desk");
            furnInvent.Add("dresser");
            furnInvent.Add("chair");

            Console.WriteLine("Enter furniture item to search inventory:");
            string userInput = Console.ReadLine();

            for (int f = 0; f < furnInvent.Count; f++)
            {
                if (furnInvent[f].Contains(userInput))
                {
                    Console.WriteLine(furnInvent.IndexOf(userInput));
                }
                else
                {
                    Console.WriteLine("Not on the list.");
                }
                Console.ReadLine();
               
            }






        }
    }
}
