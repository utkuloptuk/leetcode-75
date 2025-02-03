namespace leetcode_75._61_rotate_list;

 public class ListNode {
     public int val;
    public ListNode next;
     public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
 }
public class Solution
{
    public ListNode RotateRight(ListNode head, int k) {
        if (head == null||head.next == null||k==0)
        {
            return head;
        }

        int len = 1;
        ListNode current = head;
        while (current.next != null)
        {
            current = current.next;
            len++;
        }
        int mode=k%len;
        if (mode == 0)
            return head;
        ListNode newNode = head;
        for(int i=0;i<len-mode-1; i++)
            newNode = newNode.next;
        ListNode newHead = newNode.next;
        newNode.next = null;
        current.next = head;
        return newHead;
        //deeeep seeek versiyonu
        // Edge cases: empty list or single node
        // if (head == null || head.Next == null || k == 0)
            return head;

        // Step 1: Calculate the length of the list
        // int length = 1;
        // ListNode tail = head;
        // while (tail.Next != null)
        // {
        //     tail = tail.Next;
        //     length++;
        // }
        //
        // // Step 2: Calculate the effective number of rotations
        // k = k % length;
        // if (k == 0) // No rotation needed
        //     return head;
        //
        // // Step 3: Find the new tail (node at position length - k - 1)
        // ListNode newTail = head;
        // for (int i = 0; i < length - k - 1; i++)
        // {
        //     newTail = newTail.Next;
        // }
        //
        // // Step 4: Reconnect the nodes
        // ListNode newHead = newTail.Next; // New head is the node at position length - k
        // newTail.Next = null; // Break the list at the new tail
        // tail.Next = head; // Connect the original tail to the original head
        //
        // return newHead;
        // tekil olan tekrar bakılmalı
        // if (head == null||head.next == null)
        //     return head;
        // ListNode seconder = head;
        // while (seconder.next.next != null)
        // {
        //     seconder=seconder.next;
        // }
        // ListNode last = seconder.next;
        // seconder.next = null;
        // last.next = head;
        // return last;

    }
}