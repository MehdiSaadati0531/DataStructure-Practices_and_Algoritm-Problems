namespace CircularLinkedList
{
    class Node
    {
        public int Value;
        public Node Next;
        public Node Prev;
    }


    public class Implement
    {
        Node head = null;
        Node lastItem = null;

        private bool IsNull()
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

        public void Add(int val)
        {
            if (IsNull())
            {
                Node firstAdd = new Node();
                firstAdd.Value = val;
                firstAdd.Prev = firstAdd;
                firstAdd.Next = firstAdd;
                head = firstAdd;
                lastItem = head;
            }
            else
            {
                Node newnode = new Node();
                newnode.Value = val;

                lastItem.Next = newnode;
                newnode.Prev = lastItem;
                newnode.Next = head;
                lastItem = newnode;
                head.Prev = lastItem;
            }
        }

        public void Delete()
        {
            if (IsNull())
            {
                Console.WriteLine("Is Empty!!!");
            }
            else
            {
                if (lastItem == head)
                {
                    head = null;
                }
                else
                {
                    var temp = head.Next;
                    head = null;
                    temp.Prev = lastItem;
                    lastItem.Next = temp;
                    head = temp;
                }
            }
        }

        public void Print()
        {
            if (IsNull())
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine($"val=> {head.Value}");
                var temp = head.Next;
                while (temp != head)
                {
                    Console.WriteLine($"val=> {temp.Value}");
                    temp = temp.Next;
                }
            }
        }
    }
}
