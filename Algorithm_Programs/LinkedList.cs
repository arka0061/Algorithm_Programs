using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithm_Programs
{
    public class Linked_List<T> where T:IComparable
    {
        static readonly string textFile = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\UnorderedText.txt";
        static readonly string textFile2 = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\OrderedNumbers.txt";    
        Node<T> head = null;
        public int counter=0;           
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted "+node.data);
                counter++;

            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted "+node.data);
                counter++;
            }          
        }
       
        public void DisplayUnordered()
        {
            Node<T> temp = head;
            File.WriteAllText(textFile, String.Empty);
            while (temp != null)
            {               
                using (StreamWriter stream = new StreamWriter(textFile, true))stream.Write(temp.data);        
                Console.Write(temp.data + " ");           
                temp = temp.next;
                if (temp != null)
                {
                    using(StreamWriter stream = new StreamWriter(textFile, true))stream.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Write("Enter Your choice!");
        }
        public void DisplayOrdered()
        {
            Node<T> temp = head;
            File.WriteAllText(textFile2, String.Empty);             
            while (temp != null)
            {
               using (StreamWriter stream = new StreamWriter(textFile2, true)) stream.Write(temp.data);                
               Console.Write(temp.data + " ");
               temp = temp.next;
                if(temp!=null)
                {
                    using(StreamWriter stream = new StreamWriter(textFile2, true)) stream.Write(",");
                }
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Write("Enter Your choice!");
        }
        public void Delete(T data)
        {
            Node<T> temp = head;
            Node<T> prev = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (temp.data.Equals( data))
            {
                head = temp.next;             
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data.Equals(data))
                    {
                        prev.next = temp.next;
                        Console.WriteLine("Deleted "+ temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("Empty");
                }
            }
        }
    }
}
