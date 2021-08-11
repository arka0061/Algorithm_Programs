using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class PrimeOrNot
    {
        public void display()
        {
            int[] arr = new int[1000];
            int[] primeNumbers = this.prime(arr);
            for(int i=0;i<primeNumbers.Length;i++)
            {
                if (primeNumbers[i] == 0)
                {
                    break;
                }
                Console.WriteLine(primeNumbers[i] + " is a prime Number");
            }
        }
        public int[] prime(int[] array)
        {
            int number = 1000;
            int arrayCounter = 0;          
            int count = 0;
            for (int j = 1; j <=number; j++)
            {          
                for (int i = 1; i <= j; i++)
                {
                    if (j % i == 0)
                    {
                        count++;                       
                    }
                }
                if (count == 2) 
                {                 
                    array[arrayCounter] = j;
                    arrayCounter++;                  
                }
                count = 0;
            }
            return array;
        }
        
    }
}
        

