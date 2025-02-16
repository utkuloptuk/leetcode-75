using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._61_rotate_list;
[TestClass]
public class SolutionTest
{
     [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 4, 5, 1, 2, 3 })] // Rotate right by 2
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 1, 2, 3, 4, 5 })] // Rotate right by length (no change)
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 7, new int[] { 4, 5, 1, 2, 3 })] // Rotate right by k > length (k % length = 2)
    [DataRow(new int[] { 1 }, 1, new int[] { 1 })] // Single node, rotate by 1 (no change)
    [DataRow(new int[] { 1, 2 }, 1, new int[] { 2, 1 })] // Rotate right by 1
    [DataRow(new int[] { 1, 2 }, 2, new int[] { 1, 2 })] // Rotate right by length (no change)
    [DataRow(new int[] { 1, 2, 3 }, 3, new int[] { 1, 2, 3 })] // Rotate right by length (no change)
    [DataRow(new int[] { 1, 2, 3 }, 4, new int[] { 3, 1, 2 })] // Rotate right by k > length (k % length = 1)
    public void TestRotateRight(int[] input, int k, int[] expectedOutput)
    {
        // Arrange: Create the linked list from the input array
        ListNode head = CreateLinkedList(input);

        // Act: Call the RotateRight method
        ListNode result = new Solution().RotateRight(head, k);

        // Assert: Verify the result matches the expected output
        CollectionAssert.AreEqual(expectedOutput, ConvertLinkedListToArray(result));
    }

    // Helper method to create a linked list from an array
    private ListNode CreateLinkedList(int[] values)
    {
        if (values == null || values.Length == 0)
            return null;

        ListNode head = new ListNode(values[0]);
        ListNode current = head;
        for (int i = 1; i < values.Length; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
        return head;
    }

    // Helper method to convert a linked list to an array
    private int[] ConvertLinkedListToArray(ListNode head)
    {
        List<int> result = new List<int>();
        ListNode current = head;
        while (current != null)
        {
            result.Add(current.val);
            current = current.next;
        }
        return result.ToArray();
    }
}