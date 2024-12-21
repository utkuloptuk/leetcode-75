using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._26_remove_duplicates_sorted_array;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,1,2},2,new int[]{1,2,1})]
    [DataRow(new int[] { 0,0,1,1,1,2,2,3,3,4},5,new int[]{0,1,2,3,4,0,1,1,2,3 })]
    
    public void Remove_Element_Is_Succeed_Case(int[] nums,int result, int[] expectedResult)
    {
        var res=Solution.RemoveDuplicatedSortedArray(nums);
        // Assert.IsTrue(nums.SequenceEqual(expectedResult));
        Assert.AreEqual(result,res);
    }
}