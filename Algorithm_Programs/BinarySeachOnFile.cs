using System;
using System.IO;

namespace Algorithm_Programs
{
    class BinarySearchOnFile : IComparable
    {
       static readonly string textFile = @"E:\\Bridglabz\\Algorithm_Programs\\Algorithm_Programs\\Word.txt";
       public void file()
        {
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                String[] tokens = text.Split(",");
                string[] array = new string[tokens.Length];      
                Console.WriteLine("Enter the word to be searched :");
                string word = Console.ReadLine();
                Array.Sort(tokens);              
                int result = binarySearch(tokens, word);
                if (result != -1)
                {
                    Console.WriteLine("Element found ");
                }
                else
                    Console.WriteLine("Element not present");        
            }        
        }
        public int binarySearch(String[] array, String x)
        {
            int length = 0, range = array.Length - 1;       
            while (length <= range)
            {
                int mid = length + (range - length) / 2;

                int result = x.CompareTo(array[mid]);

                /// Check if x is present at mid
                if (result == 0)
                    return mid;

                // /If x greater, ignore left half
                if (result > 0)
                    length = mid + 1;

                /// If x is smaller, ignore right half
                else
                    result = mid - 1;
            }
            return -1;
        }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}