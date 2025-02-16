using leetcode_75._160_intersection_of_two_linked_list;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GetIntersectionNodeTests
{
    [TestMethod]
    [DataRow(new int[] { 4, 1 }, new int[] { 5, 6, 1 }, new int[] { 8, 4, 5 }, 2, 3, 1)] // Intersection at node with value 8
    [DataRow(new int[] { 1, 9, 1 }, new int[] { 3 }, new int[] { 2, 4 }, 3, 1, 2)] // Intersection at node with value 2
    [DataRow(new int[] { 2, 6, 4 }, new int[] { 1, 5 }, new int[] { }, 3, 2, -1)] // No intersection
    [DataRow(new int[] { }, new int[] { 1, 5 }, new int[] { }, 0, 2, -1)] // Empty list A
    [DataRow(new int[] { 1 }, new int[] { }, new int[] { }, 1, 0, -1)] // Empty list B
    [DataRow(new int[] { 1 }, new int[] { 1 }, new int[] { }, 1, 1, -1)] // No intersection, same values
    public void TestGetIntersectionNode(int[] listA, int[] listB, int[] commonList, int skipA, int skipB, int expectedValue)
    {
        // Arrange: Create the linked lists
        ListNode headA = CreateLinkedList(listA, commonList, skipA);
        ListNode headB = CreateLinkedList(listB, commonList, skipB);

        // Act: Call the GetIntersectionNode method
        ListNode result = new Solution().GetIntersectionNode(headA, headB);

        // Assert: Verify the result matches the expected value
        if (expectedValue == -1)
        {
            Assert.IsNull(result); // No intersection expected
        }
        else
        {
            Assert.IsNotNull(result); // Intersection expected
            Assert.AreEqual(expectedValue, result.val); // Verify the intersection node value
        }
    }

    // Helper method to create a linked list with optional common tail
    private ListNode CreateLinkedList(int[] list, int[] commonList, int skip)
    {
        if (list == null || list.Length == 0)
            return null;

        ListNode head = new ListNode(list[0]);
        ListNode current = head;

        // Add nodes from the main list
        for (int i = 1; i < list.Length; i++)
        {
            current.next = new ListNode(list[i]);
            current = current.next;
        }

        // Add nodes from the common list (if any)
        if (commonList != null && commonList.Length > 0 && skip >= list.Length)
        {
            for (int i = 0; i < commonList.Length; i++)
            {
                current.next = new ListNode(commonList[i]);
                current = current.next;
            }
        }

        return head;
    }
}