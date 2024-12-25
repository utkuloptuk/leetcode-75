namespace leetcode_75._141_linked_list_cycle;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var slowPointer = head;
        var fastPointer = head;
        while (fastPointer != null && fastPointer.next != null)
        {
            slowPointer = slowPointer.next;
            fastPointer = fastPointer.next.next;
            if(slowPointer == fastPointer)
                return true;
        }

        return false;
    }
}

public class ListNode { 
    public int val;
    public ListNode next;
    public ListNode(int x) {
        val = x;
        next = null;
    }
}