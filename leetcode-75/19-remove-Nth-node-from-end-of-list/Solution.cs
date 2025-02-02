namespace leetcode_75._19_remove_Nth_node_from_end_of_list;

public class Solution
{
    
    //O(n) time comp, O(1) memory complexity
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
 
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        int count = 0;
        ListNode current = head;
        while (current != null)
            {
                count++;
                current = current.next;
            }
        if (count == n)
             return head.next;
        int traverseCount = count-n-1;
        ListNode result = head;
        while (traverseCount > 0)
        {
            result=result.next;
            traverseCount--;
        }
        result.next=result.next.next;
        return head;
    }
}