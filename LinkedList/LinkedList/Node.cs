using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }

    public class NodeOperation
    {
        Node head = new()
        {
            Value = 1,
            Next = null
        };
        Node current;

        public NodeOperation()
        {
            current = head;
            head.Next = current;
        }

        public void Insert(int val)
        {
            Node x = new()
            {
                Value=val
            };
            current.Next = x;
            current = x;
        }

        public void Print() 
        {
            for (Node i = head; i != current.Next;)
            {
                Console.WriteLine(i.Value);
                i = i.Next;
            }
        }
    }
}
