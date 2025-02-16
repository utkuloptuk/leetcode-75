using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._19_remove_Nth_node_from_end_of_list;
[TestClass]
public class SolutionTest
{
  [TestMethod]
  [DataRow(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })] // Remove 2nd from end
  [DataRow(new int[] { 1 }, 1, new int[] { })] // Remove the only element
  [DataRow(new int[] { 1, 2 }, 1, new int[] { 1 })] // Remove last element
  [DataRow(new int[] { 1, 2 }, 2, new int[] { 2 })] // Remove first element
  [DataRow(new int[] { 1, 2, 3 }, 3, new int[] { 2, 3 })] // Remove first element (n = size)
  [DataRow(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 2, 3, 4, 5 })] // Remove first element (n = size)
  [DataRow(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 1, 2, 3, 4 })] // Remove last element
  public void TestRemoveNthFromEnd(int[] input, int n, int[] expectedOutput)
  {
    // Arrange: Create the linked list from the input array
    ListNode head = CreateLinkedList(input);

    // Act: Call the RemoveNthFromEnd method
    ListNode result = Solution.RemoveNthFromEnd(head, n);

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