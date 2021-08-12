using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm_Programs
{
    public class Node
    {
        public string data;
        public Node next = null;
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
