namespace leetcode_75._160_intersection_of_two_linked_list;

public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var pointerA = headA;
        var pointerB = headB;
        while (pointerA != null && pointerB != null)
        { 
            pointerA= pointerA==null?headB:pointerA.next;
            pointerB = pointerB==null?headA:pointerB.next;
        }
        return pointerA;
        // var fastPointer = headA;
        // var slowPointer=headB;
        // while (slowPointer.next != null && fastPointer.next != null)
        // {
        //     if(slowPointer.val == fastPointer.val)
        //         return fastPointer;
        //
        //     if (fastPointer.next == null)
        //     {
        //         fastPointer = headA;
        //         slowPointer = slowPointer.next;
        //     }
        //
        //
        //     slowPointer = slowPointer.next;
        //
        // }
        // return null;
    }
}

 public class ListNode {
    public int val;
     public ListNode next;
     public ListNode(int x) { val = x; }
}