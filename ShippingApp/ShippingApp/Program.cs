
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shippingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("Please enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            if (pkgWeight >= 50)
            {
                Console.WriteLine("Your package is too heavy to be shipped.  Have a nice day.");
                Console.ReadLine();
            }
            else if (pkgWeight <= 50)
            {
                Console.WriteLine("Please enter the package width");
            }
            int pkgWidth = Convert.ToInt32(Console.ReadLine());
            if (pkgWidth >= 50)
            {
                Console.WriteLine("Your package is too large.");
                Console.ReadLine();
            }
            else if (pkgWidth <= 50)
            {
                Console.WriteLine("Please enter the package height:");
            }
            int pkgHeight = Convert.ToInt32(Console.ReadLine());
            if (pkgHeight >= 50)
            {
                Console.WriteLine("Your package is too tall.");
                Console.ReadLine();
            }
            else if (pkgHeight <= 50)
            {
                Console.WriteLine("Please enter package length:");
            }
            int pkgLength = Convert.ToInt32(Console.ReadLine());
            if (pkgLength >= 50)
            {
                Console.WriteLine("Your package is too long");
                Console.ReadLine();
            }
            else if (pkgLength < 50)
            {
                Console.WriteLine("Your total cost is:");
            }
            // ((h*wdth*l) * length) / 100
            double total1 = pkgHeight * pkgWidth * pkgLength;
            double finalTotal = (total1 * pkgWeight) / 100;
            float convertedTotal = Convert.ToSingle(finalTotal);
            Console.WriteLine(finalTotal);
            Console.ReadLine();




        }
    }
}
