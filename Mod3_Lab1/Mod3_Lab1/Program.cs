using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int result = Sum(20, 40);
            Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

            double dblResult = Sum(20.5, 30.6);
            Console.WriteLine($"Calling Sum() that takes souble result in: {dblResult}");
        }

        //sum() method that takes two integer arguments and sums them
        // The method returns an integer which is why we use int in the signature
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }

        // Sum() method that takes three integer arguments and sums them and then returns the value
        // This method uses the same name as the Sum() method that takes two integers 
        // but the parameters here indicate the method is expecting three integers as arguments
        // The compiler knows which method to cal based on the number of arguments passed in

        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }

        // Sum() method that takes two doubles as arguments
        // This method uses the same name as the Sum() method that takes two integers
        // but the parameters here indicate the method is expecting two doubles as arguments
        // The compiler knows which method to call based on the arguments data types

        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }
    }
}
