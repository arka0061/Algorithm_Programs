using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Algorithm_Programs
{
    public class Linked_List
    {
        static readonly string textFile = @"E:\Bridglabz\Algorithm_Programs\Algorithm_Programs\textfile.txt";
        Node head = null;      
        public void Add(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted "+node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted "+node.data);
            }
        }       
        public void Display()
        {
            Node temp = head;
            File.WriteAllText(textFile, String.Empty);
            while (temp != null)
            {               
                using (StreamWriter stream = new StreamWriter(textFile, true))            
                stream.Write(temp.data+",");                                                   
                Console.Write(temp.data + " ");
                temp = temp.next;               
            }
        }     
        public void Delete(string data)
        {
            Node temp = head;
            Node prev = head;
            if (temp == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            else if (temp.data == data)
            {
                head = temp.next;             
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data == data)
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
