using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class PrimePalindrome
    {
        public int TEN = 10;
        public void PrimeAndPaldindrome()
        {

            List<string> anagramList = new List<string>();
            PrimeOrNot obj = new PrimeOrNot();
            int[] arr = new int[1000];
            int[] newArray = obj.Prime(arr);                                      
            int num, rem, sum = 0, temp;
            for (int i = 0; i < newArray.Length; i++)
            {
                  if (newArray[i] == 0)
                   {
                       break;
                   }         
                num = newArray[i];
                temp = num;
                while (num > 0)     
                {
                    rem = num % 10;  
                    num = num / 10;     
                    sum = sum * 10 + rem;                   
                }            
                if (temp == sum)   
                {
                    Console.WriteLine("Number "+newArray[i]+" is palindrome and prime!");
                }
                rem = 0;
                num = 0;
                sum = 0;
              
            }
        }
    }
}
