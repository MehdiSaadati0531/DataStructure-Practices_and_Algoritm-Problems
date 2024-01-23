using Remove_Duplicates_from_SortedList;


//ListNode e = new ListNode() {val = 3, next = null };
//ListNode d = new ListNode() {val = 3, next = e };
ListNode c = new ListNode() {val = 1, next = null };
ListNode b = new ListNode() {val = 1, next = c };
ListNode head = new ListNode() {val = 1, next = b };

Solution a = new Solution();

Console.WriteLine(a.DeleteDuplicates(head));