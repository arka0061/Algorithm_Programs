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
        public void insertionSort(string[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                string value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
            this.write(array);
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
                        stream.Write(item+",");                     
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
