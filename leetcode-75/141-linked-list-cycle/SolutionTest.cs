using leetcode_75._141_linked_list_cycle;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class HasCycleTests
{
    [TestMethod]
    [DataRow(new int[] { 3, 2, 0, -4 }, 1, true)] // Cycle exists (tail connects to node at index 1)
    [DataRow(new int[] { 1, 2 }, 0, true)] // Cycle exists (tail connects to node at index 0)
    [DataRow(new int[] { 1 }, -1, false)] // No cycle (single node)
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, -1, false)] // No cycle (linear list)
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, 4, true)] // Cycle exists (tail connects to node at index 4)
    [DataRow(new int[] { }, -1, false)] // Empty list
    public void TestHasCycle(int[] values, int pos, bool expectedResult)
    {
        // Arrange: Create the linked list with or without a cycle
        ListNode head = CreateLinkedList(values, pos);

        // Act: Call the HasCycle method
        bool result = new Solution().HasCycle(head);

        // Assert: Verify the result matches the expected result
        Assert.AreEqual(expectedResult, result);
    }

    // Helper method to create a linked list with or without a cycle
    private ListNode CreateLinkedList(int[] values, int pos)
    {
        if (values == null || values.Length == 0)
            return null;

        ListNode[] nodes = new ListNode[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            nodes[i] = new ListNode(values[i]);
            if (i > 0)
                nodes[i - 1].next = nodes[i];
        }

        // Create a cycle if pos is valid
        if (pos >= 0 && pos < values.Length)
            nodes[values.Length - 1].next = nodes[pos];

        return nodes[0];
    }
}