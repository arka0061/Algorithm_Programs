using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithm_Programs
{
    public class OrderedList
    {
        static readonly string textFile = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\OrderedNumbers.txt";
        public Linked_List<int> list = new Linked_List<int>();
        public void driver()
        {
            List<int> numbers = new List<int>();
            string text = File.ReadAllText(textFile);
            String[] tokens = text.Split(",");
            for (int i = 0; i < tokens.Length; i++)
            {
                numbers.Add(int.Parse(tokens[i]));
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                list.Add(item);
            }
            Console.WriteLine("Enter a number to search :");
            int search = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (count < tokens.Length)
            {
                if (search == numbers[count])
                {
                    Console.WriteLine("Word Found");
                    list.Delete(numbers[count]);
                    list.DisplayOrdered();
                    return;
                }
                count++;
            }
            list.Add(search);
            list.DisplayOrdered();
        }
    }
}
