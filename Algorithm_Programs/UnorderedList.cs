using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithm_Programs
{
    public class UnorderedList
    {
        static readonly string textFile = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\UnorderedText.txt";
        public Linked_List<string> list = new Linked_List<string>();
        public void driver()
        {                        
            if (File.Exists(textFile))
            {
                string text = File.ReadAllText(textFile);
                String[] tokens = text.Split(",");
                for (int i = 0; i < tokens.Length; i++)
                {
                    list.Add(tokens[i]);
                }
                Console.WriteLine("Enter a word to search :");
                string search = Console.ReadLine();
                int count=0;
                while (count < tokens.Length)
                {
                    if (search == tokens[count])
                    {
                        Console.WriteLine("Word Found");
                        list.Delete(tokens[count]);                        
                        list.DisplayUnordered();
                        return;
                    }
                    count++;
                }
                list.Add(search);
                list.DisplayUnordered();               
            }
        }     
    }
}

