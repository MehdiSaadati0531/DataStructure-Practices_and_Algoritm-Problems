using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLinkedList
{
    public class Node
    {
        public int Value;
        public Node Next;
    }

    public class QueueImplementLinkedList
    {
        Node head;
        Node rear;

        bool IsEmpty() 
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeQueue() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Empty!!!");
            }
            else
            {
                head = head.Next;
            }
        }

        public void EnQueue(int val) 
        {
            if (IsEmpty())
            {
                Node newnode = new Node();
                newnode.Value = val;
                head = newnode;
                head.Next = null;
                rear = head;
            }
            else
            {
                Node newNode = new Node();
                newNode.Value = val;
                rear.Next = newNode;
                rear = newNode; 
            }
        }

        public void Print() 
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue Is Empty!!!");
            }
            else
            {
                Node temp = head;
                while (temp != rear.Next)
                {
                    Console.WriteLine(temp.Value);
                    temp = temp.Next;
                }
            }
        }
    }
}
