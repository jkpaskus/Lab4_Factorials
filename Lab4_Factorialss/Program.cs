using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Factorialss
{
    class Program
    {
        static void Main(string[] args)
        {
            //Establish min and max values.
            int min = 0;
            int max = 10;

            Console.WriteLine("Welcome to the Factorial Calculator!\n\n");
            Console.Write("Enter an integer that's greater than {0} but less than {1}: ", min, max);

            //Collect number that the user input.
            int number = Convert.ToInt32(Console.ReadLine());
            double factorial = Factorial(number);
            Console.WriteLine("The factorial of {0} is {1}", number, factorial);
        }

        public static double Factorial(int number)
        {
            if (number == 0)
                return 1;

            double factorial = 1;

            for (int i = number; i >=1; i--)
            {
                factorial = factorial * i;
            }

            return factorial;
        }
    }
}
