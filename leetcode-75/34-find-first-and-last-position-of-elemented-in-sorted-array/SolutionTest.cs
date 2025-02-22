using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._34_find_first_and_last_position_of_elemented_in_sorted_array;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 5,7,7,8,8,10 }, 8, new int[] { 3,4})] // Rotate right by 2
    [DataRow(new int[] {5,7,7,8,8,10}, 6, new int[] { -1,-1 })] // Rotate right by length (no change)
    [DataRow(new int[] {  }, 0, new int[] { -1,-1})]
    [DataRow(new int[] { 1 }, 1, new int[] { 0,0})]
    [DataRow(new int[] { 2,2 }, 3, new int[] { -1,-1})]
    [DataRow(new int[] { 2,2 }, 2, new int[] { 0,1})]
    [DataRow(new int[] { 1,3 }, 1, new int[] { 0,0})]
    public void find_index_is_Succeed(int[] numbs, int target, int[] expected)
    {
        var num =Solution.SearchRange(numbs, target);
        CollectionAssert.AreEqual(expected, num);
    }
}