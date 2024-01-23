using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stac
{
    public class Stack_Aray
    {
        private int[] Araye;
        private int top;

        public Stack_Aray(int size)
        {
            Araye = new int[size];
            top = -1;
        }

        public bool IsFull()
        {
            if (top == Araye.Length - 1)
                return true;
            return false;
        }

        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            return false;
        }

        public void Push(int NewNumber)
        {
            if (IsFull())
            {
                Console.WriteLine("Stac OverFlow");
                return;
            }
            ++top;
            Araye[top] = NewNumber;
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stac UnderFlow");
                return;
            }
            Console.WriteLine(Araye[top]);
            top--;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stac UnderFlow");
                return;
            }
            Console.WriteLine(Araye[top]);
        }

        public void Stack_display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stac UnderFlow");
                return;
            }
            for (int i = Araye.Length-1; i > -1; i--)
            {
                Console.WriteLine(Araye[i]);
            }
        }
    }
}
