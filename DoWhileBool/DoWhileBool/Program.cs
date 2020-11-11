using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileBool
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            do
            {
                Console.WriteLine("Counting down... in " + (n));
                n--;
            }
            while (n >= 0);
            Console.ReadLine();
        }
           
    }
}
