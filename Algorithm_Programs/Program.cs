﻿using System;

namespace Algorithm_Programs
{
    class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorith Programs!");
            Console.WriteLine("Press 1 for Factorial using Iteration and Recursion!");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            while (choice != 15)
            {
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Factorial using iteraion and recursion!");
                        IterationAndRecursion rec = new IterationAndRecursion();
                        rec.FactorialUsingIteration();
                        Console.WriteLine("Enter a number");          
                        int number = Convert.ToInt32(Console.ReadLine());
                        long fact = rec.FactorialUsingRecursion(number);
                        Console.WriteLine("Factorial of " + number + " using Recursion is: " + fact);
                        break;
                }
            }
        }
    }
}