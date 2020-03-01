using System;

namespace Methods
{
    class Program
    {
        // the method perform calculation
        static int Calculate(int a, int b, char flag)
        {
            // add
            if (flag == '+')
                return a + b;

            // subtract
            if (flag == '-')
                return a - b;

            // multiply
            if (flag == '*')
                return a * b;

            // divide
            if (flag == '/')
                return a / b;

            // return 0 as dummy value
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kelly K Duong");

            // call the method to add two numbers
            Console.WriteLine("The sum of 6 and 3 is " + Calculate(6, 3, '+') + ".");

            // call the method to subtract two numbers
            Console.WriteLine("The difference of 6 and 3 is " + Calculate(6, 3, '-') + ".");

            // call the method to multiply two numbers
            Console.WriteLine("The product of 6 and 3 is " + Calculate(6, 3, '*') + ".");

            // call the method to divide two numbers
            Console.WriteLine("The quotient of 6 and 3 is " + Calculate(6, 3, '/') + ".");
        }
    }
}
