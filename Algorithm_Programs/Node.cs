using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class Node <T> where T :IComparable
    {
        public T data;
        public Node<T> next = null;
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
