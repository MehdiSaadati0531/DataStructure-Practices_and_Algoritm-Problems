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
            if (top == Araye.Length)
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
                throw new Exception("Stac OverFlow");
            }
            else
            {
                ++top;
                Console.Write(Araye[top] = NewNumber);
            }
        }

        public int Pop() 
        {
            if (IsEmpty())
            {
                throw new Exception("Stac UnderFlow");
            }
            else
            {
                Console.Write(Araye[top]);
                return Araye[top--];
            }
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                throw new Exception("Stac UnderFlow");
            }
            else
            {
                Console.Write(Araye[top]);
            }
        }

    }
}
