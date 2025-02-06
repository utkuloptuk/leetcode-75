using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._977_squares_of_sorted_array;
[TestClass]
public class SolutionTest
{
    [TestMethod]
     [DataRow(new int[] { -4,-1,0,3,10}, new int[] { 0,1,9,16,100})]
    [DataRow(new int[] { -7,-3,2,3,11}, new int[] { 4,9,9,49,121 })]
    public void Sorting_Squered_is_Succeed(int[] numbs, int[] excepted_result)
    {
        var result = Solution.SortedSquares(numbs);
        Assert.IsTrue(result.SequenceEqual(excepted_result));

    }
}