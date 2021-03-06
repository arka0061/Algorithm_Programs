using System;

namespace Algorithm_Programs
{
    class Program
    {
        public static int choice;
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorith Programs!");
            Console.WriteLine("Press 1 for Factorial using Iteration and Recursion!");
            Console.WriteLine("Press 2 for Binary Search on Textfile!");
            Console.WriteLine("Press 3 for Insertion Sort on Textfile!");
            Console.WriteLine("Press 4 for Bubble Sort!");
            Console.WriteLine("Press 5 for Merge Sort!");
            Console.WriteLine("Press 6 for Anagram!");
            Console.WriteLine("Press 7 for Prime Number!");
            Console.WriteLine("Press 8 for Palindrome and Prime!");
            Console.WriteLine("Press 9 for UnorderedList!");
            Console.WriteLine("Press 10 for OrderedList!");
            Console.WriteLine("Press 11 for Bank Cash Counter!");
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

                    case 2:
                        Console.WriteLine("Binary Search on File!");
                        BinarySearchOnFile obj = new BinarySearchOnFile();
                        obj.CheckFile();
                        break;

                    case 3:
                        Console.WriteLine("Insertion Sort on File!");
                        InsertionSort sort = new InsertionSort();
                        sort.file();
                        break;

                    case 4:
                        Console.WriteLine("Bubble Sort!");
                        BubbleSort bubble = new BubbleSort();
                        bubble.CheckBubbleSort();
                        break;


                    case 5:
                        Console.WriteLine("Merge Sort!");
                        MergeSort merge = new MergeSort();
                        merge.Input();
                        break;

                    case 6:
                        Console.WriteLine("Anagram!");
                        Anagram anagram = new Anagram();
                        anagram.AnagramCheck();
                        break;


                    case 7:
                        Console.WriteLine("Prime Number!");
                        PrimeOrNot prime = new PrimeOrNot();
                        prime.Display();
                        break;

                    case 8:
                        Console.WriteLine("Palindrome and Prime!");
                        PrimePalindrome pap = new PrimePalindrome();
                        pap.PrimeAndPaldindrome();
                        break;

                    case 9:
                        Console.WriteLine("Unordered List!");
                        UnorderedList unordered = new UnorderedList();
                        unordered.Driver();
                        break;

                    case 10:
                        Console.WriteLine("Ordered List!");
                        OrderedList ordered = new OrderedList();
                        ordered.Driver();
                        break;

                    case 11:
                        Console.WriteLine("Bank Cash Counter!");
                        BankCashCounter bank = new BankCashCounter();
                        bank.Driver();
                        break;
                }
            }
        }
    }
}
