using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._234_palindrome_linked_list;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1 }, true)] // Test single element list
    [DataRow(new int[] { 1, 2, 2, 1 }, true)] // Test even-length palindrome
    [DataRow(new int[] { 1, 2, 3, 2, 1 }, true)] // Test odd-length palindrome
    [DataRow(new int[] { 1, 2, 3, 4 }, false)] // Test even-length non-palindrome
    [DataRow(new int[] { 1, 2, 3, 4, 5 }, false)] // Test odd-length non-palindrome
    [DataRow(new int[] { -1, 2, 2, -1 }, true)] // Test palindrome with negative numbers
    [DataRow(new int[] { -1, 2, 3, -1 }, false)] // Test non-palindrome with negative numbers
    public void TestIsPalindrome(int[] values, bool expectedResult)
    {
        // Arrange: Create the linked list from the input array
        ListNode head = CreateLinkedList(values);

        // Act: Call the IsPalindrome method
        bool result = new Solution().IsPalindrome(head);

        // Assert: Verify the result matches the expected result
        Assert.AreEqual(expectedResult, result);
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
    //linkedliste test yazmayı ogren
}