using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._80_remove_duplicates_sorted_array_2;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,1,1,2,2,3 },5,new int[]{1,1,2,2,3,1})]
    [DataRow(new int[] { 0,0,1,1,1,1,2,3,3},7,new int[]{0,0,1,1,2,3,3,1,1})]
    
    public void Sorted_Array_Is_Succeed_Case(int[] nums,int result, int[] expectedResult)
    {
        var res=Solution.RemoveDuplicates(nums);
        // Assert.IsTrue(nums.SequenceEqual(expectedResult));
        Assert.AreEqual(result,res);
    }
}