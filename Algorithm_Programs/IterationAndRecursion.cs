using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    class IterationAndRecursion
    {
        public void FactorialUsingIteration()
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + " using iteration is: " + fact);
        }
        public long FactorialUsingRecursion(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * FactorialUsingRecursion(number - 1);

        }
    }
}
