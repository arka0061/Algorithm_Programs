using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class Queue<T> where T : IComparable
    {
        Node<T> head = null;
        public void Enqueue(T data)
        {
            int position_head = 0;
            int position = 2;
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
                position_head++;
                Console.WriteLine( node.data +" "+"You are "+position_head+" in queue");
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                    position++;
                }
                temp.next = node;
                Console.WriteLine(node.data + " " + "You are " + position+ " in queue");
            }
        }     
        public void Dequeue(string data)
        {
            Node<T> temp = head;
            Node<T> prev = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else if (temp.data.Equals(data))
            {
                head = temp.next;
                Console.WriteLine("Your transcation is complete : " + " " + data);
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data.Equals(data))
                    {
                        prev.next = temp.next;               
                        Console.WriteLine("Your transaction is complete" + " " + temp.data);
                        return;
                    }
                    prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
        public void IsEmpty()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
            }
        }
    }
}
