using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode head = new ListNode();

        ListNode result = head;

        while (list2 != null && list1 != null)
        {
            if (list1.val <= list2.val)
            {
                result.next = list1;
                list1 = list1.next;
                result = result.next;
            }

            else
            {
                result.next = list2;
                list2 = list2.next;
                result = result.next;
            }
        }

        if (list1 != null)
            result.next = list1;
        else if (list2 != null)
            result.next = list2;
        return head.next;
    }
}