namespace leetcode_75._234_palindrome_linked_list;

public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        // O(n) time O(n) memory 
        List<int> list = new List<int>();
        ListNode node=head;
        list.Add(node.val);
        while (node.next != null)
        {
            list.Add(node.next.val);
            node=node.next;
        }
        int end = list.Count-1;
        for (int i = 0; i <= list.Count/2; i++)
        {
            if(list[i] != list[end])
                return false;
            end--;
        }
        return true;
    }
}
 public class ListNode {
     public int val;
   public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next; 
}
}
