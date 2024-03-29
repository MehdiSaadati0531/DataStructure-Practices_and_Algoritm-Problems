﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortLinkedList
{
    public class Node
    {
        public int value;
        public Node next;
    }

    public class Operation
    {
        Node head = null;


        public bool IsNull()
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

        public void Enqueue(int value)
        {
            if (!IsNull())
            {
                Node newNode = new Node();
                Node tempNode = head;

                while (tempNode.next != null)
                {
                    tempNode = tempNode.next;
                }

                newNode.value = value;
                tempNode.next = newNode;

            }
            else
            {
                Node newNode = new Node();
                newNode.value = value;
                newNode.next = null;
                head = newNode;
            }
        }

        public void SortLinkedList()
        {
            if (!IsNull())
            {
                var tempHead = head;

                for (Node i = tempHead; i != null; i = i.next)
                {
                    for (Node j = i.next; j != null; j = j.next)
                    {
                        if (i.value > j.value)
                        {
                            var temp = j.value;
                            j.value = i.value;
                            i.value = temp;
                        }
                    }
                }
            }
        }

        public void Solve(Node start)
        {
            if (start == null)
                return;
            Console.WriteLine(start.value);

            if (start.next != null)
                Solve(start.next.next);
            Console.WriteLine(start.value);
        }

        public void SortLinkedListRevers()
        {
            if (!IsNull())
            {
                var tempHead = head;

                for (Node i = tempHead; i != null; i = i.next)
                {
                    for (Node j = i.next; j != null; j = j.next)
                    {
                        if (i.value < j.value)
                        {
                            var temp = j.value;
                            j.value = i.value;
                            i.value = temp;
                        }
                    }
                }
            }
        }

        int puzzle(Node head)
        {

            if (head == null )
            {
                return 0;
            }

            else
            {
                return 1 + puzzle(head.next);
            }
        }

        public void Print()
        {
            if (!IsNull())
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine($"value : {current.value}");
                    current = current.next;
                }
            }
            else
            {
                Console.WriteLine("Queue Is Null!");
            }
        }

        public void PrintSolve() 
        {
            Solve(head);
        }

        public void printpuzzle() 
        {
            Console.WriteLine(puzzle(head));
        }

    }

}