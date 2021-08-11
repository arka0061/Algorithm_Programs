using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class Anagram
    {
        public void anagramCheck()
        {     
            Console.WriteLine("Enter 1st String");
            String string1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd String");
            String string2 = Console.ReadLine();
            if (string1.Length == string2.Length)
            {
                int count = 0;
                char[] ch1 = string1.ToCharArray();
                char[] ch2 = string2.ToCharArray();
                Array.Sort(ch1);
                Array.Sort(ch2);
                for (int i = 0; i < ch1.Length; i++)
                {
                    if (ch1[i] == ch2[i])
                    {
                        count++;
                    }
                }
                if (count == string1.Length)
                {
                    Console.WriteLine("Anagram");
                }
                else
                {
                    Console.WriteLine("Not a Anagram!");
                }

            }
            else
            {
                Console.WriteLine("Not a Anagram!");
            }
        }
    }
}
