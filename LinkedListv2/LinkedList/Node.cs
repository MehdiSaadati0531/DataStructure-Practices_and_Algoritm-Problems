namespace LinkedList
{
    public class Node
    {
        public object Value { get; set; }
        public Node Next { get; set; }
    }

    public class NodeOperation
    {
        Node head = null;

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

        public void InsertFirst(object val)
        {
            Node newNode = new Node();
            if (IsNull())
            {
                head.Value = val;
                head.Next = null;
                head = newNode;
            }
            else
            {
                Node temp = head;
                head.Value = val;
                head.Next = temp;
                head = newNode;
            }
        }

        public void InsertLast(object val) 
        {
            Node newNode = new Node();
            if (IsNull())
            {
                head.Value = val;
                head.Next = null;
                head = newNode;
            }
            else
            {
                Node findLast = head;
                while (findLast != null) 
                {
                    findLast = findLast.Next;
                }
                findLast.Next = newNode;
                newNode.Value = val;
                newNode.Next = null;
            }
        }

        public void Print() 
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Value);
                temp = temp.Next;
            }
        }
    }
}
