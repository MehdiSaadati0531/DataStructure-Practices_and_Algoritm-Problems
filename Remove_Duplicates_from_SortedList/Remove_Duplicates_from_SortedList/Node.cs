namespace Remove_Duplicates_from_SortedList
{
    public class ListNode
    {
        public int val;
        public ListNode next;
    }

    public class Solution
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
                ListNode temp = head;
                while (temp != null && temp.next != null)
                {
                    if (temp.val == temp.next.val)
                    {
                        temp.next = temp.next.next;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
                return head;
        }

        // Befor Clean
        //public ListNode DeleteDuplicates(ListNode head)
        //{
        //    if (head != null)
        //    {
        //        ListNode temp = head;
        //        while (temp.next != null)
        //        {
        //            if (temp.val == temp.next.val)
        //            {
        //                temp.next = temp.next.next;
        //                continue;
        //            }
        //            if (temp.next == null)
        //            {
        //                return head;
        //            }
        //            temp = temp.next;
        //        }
        //        return head;
        //    }
        //    else
        //    {
        //        return head;
        //    }
        //}
    }
}
