using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class MergeSort
    {
        public void MainMerge<T>(T[] values, int left, int mid, int right) where T : IComparable<T>
        {
            T[] temp = new T[25];
            int i, eol, num, pos;

            eol = mid;
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (values[left].Equals(values[mid]))
                    temp[pos++] = values[left++];
                else
                    temp[pos++] = values[mid++];
            }

            while (left <= eol)
                temp[pos++] = values[left++];

            while (mid <= right)
                temp[pos++] = values[mid++];

            for (i = 0; i < num; i++)
            {
                values[right] = temp[right];
                right--;
            }
        }

        public void SortMerge<T>(T[] values, int left, int right) where T : IComparable<T>
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                SortMerge(values, left, mid);
                SortMerge(values, (mid + 1), right);
                this.MainMerge(values, left, (mid + 1), right);
            }
        }
        public void Input()
        {
            Console.WriteLine("Enter the length of an array");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[number];
            Console.WriteLine("Enter the elements in array");
            for (int i = 0; i < number; i++)
            {
                array[i] = Console.ReadLine();
            }
            int length = number;
            this.SortMerge(array,0,length-1);
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}