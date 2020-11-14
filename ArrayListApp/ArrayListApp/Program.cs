using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main()
        {
            string[] strArray = {"Today is sunny.",
                                  "Today is rainy.",
                                  "Today is cold.",
                                  "Today is windy.",
                                  "Today is magic."
                                 };

            Console.WriteLine("Please enter an index of 0 through 4.");
            int index = Convert.ToInt32(Console.ReadLine());

            if (index >= 0 && index <= 4)
            {
                Console.WriteLine(strArray[index]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry not the correct entry.");
                Console.ReadLine();
            }

            int[] numArray = { 5, 3, 4, 6, 2, 99 };

            Console.WriteLine("Now Select from a group of integers labeled\n0 through 5.");
            int numIndex = Convert.ToInt32(Console.ReadLine());

            if (numIndex >= 0 && numIndex <= 5)
            {
                Console.WriteLine(numArray[numIndex]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Error in your selection.  Stay within the options given.");
                Console.ReadLine();
            }

            Console.WriteLine("Enter another number between one and three for a totally random statement.");
            int selection = Convert.ToInt32(Console.ReadLine());

            List<string> testList = new List<string>();
            testList.Add("Who is your favorite beatmaker?");
            testList.Add("Bad Snacks makes the best beats right now.");
            testList.Add("There are so many good ones out there.");
            testList.Add("You've bored me, go back to the beginning.");

            if (selection >= 0 && selection <= 3)
            {
                Console.WriteLine(testList[selection]);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Error: Start Over");
                Console.ReadLine();
            }







            //List<string> intList = new List<string>();
            //intList.Add("Hello");
            //intList.Add("Jesse");

            //Console.WriteLine(intList[0]);
            //Console.ReadLine();
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

            //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

            //numArray2[5] = 650;
            //Console.WriteLine(numArray2[1]);
            //Console.ReadLine();
        }
    }
}
