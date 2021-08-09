using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm_Programs
{
    public class InsertionSort
    {

        static readonly string textFile = @"E:\\Bridglabz\\Algorithm_Programs\\Algorithm_Programs\\Word.txt";
        public void file()
        {
            if (File.Exists(textFile))
            {
                // Read entire text file content in one string    
                string text = File.ReadAllText(textFile);
                String[] tokens = text.Split(",");
                this.insertionSort(tokens);
            }
        }
        public void insertionSort(string[] word)
        {
            string[] tokens = word;
            for (int i = 0; i < tokens.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (tokens[j - 1].CompareTo(tokens[j]) > 0)
                    {
                        String temp = tokens[j - 1];
                        tokens[j - 1] = tokens[j];
                        tokens[i] = temp;
                    }
                }
            }
            Console.WriteLine("After sorting :");
            for (int i = 0; i < tokens.Length; i++)
            {
                Console.WriteLine(tokens[i]);
            }
            this.write(tokens);
        }
        public void write(string[] tokens)
        {
            if (File.Exists(textFile))
            {
                File.WriteAllText(textFile, String.Empty);
            }

            foreach (var item in tokens)
            {
                using (StreamWriter stream = new StreamWriter(textFile, true))
                {
                    try
                    {
                        stream.Write(item);

                    }
                    catch
                    {
                        throw;
                    }
                }
            }
        }
    }
}
