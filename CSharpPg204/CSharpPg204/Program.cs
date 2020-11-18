using System;
using System.Collections.Generic;
using System.Linq;
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
                Console.WriteLine(stringArray[i] + userName);
            }
            Console.ReadLine();

            Console.WriteLine(stringArray[2]);
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

            Console.WriteLine("What is your Age?");
            int age = Convert.ToInt32(Console.ReadLine());


        }
    }
}
