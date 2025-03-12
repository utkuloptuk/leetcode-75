using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._167_two_sum_2_input_array_sorted;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 2,7,11,15}, 9,new int[] { 1,2 })]
    [DataRow(new int[] { 2,3,4}, 6,new int[] { 1,3 })]
    [DataRow(new int[] {-1,0}, -1,new int[] { 1,2 })]
    public void duplicate_contains_check_is_succeed(int[] list,int target, int[] expectedResult)
    {
        var result = Solution.TwoSum(list,target);
        Assert.IsTrue(result.SequenceEqual(expectedResult));

    }
}