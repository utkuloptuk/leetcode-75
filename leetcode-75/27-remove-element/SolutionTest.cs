using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._27_remove_element;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 3,2,2,3}, 3,2,new int[]{2,2,0,0})]
    [DataRow(new int[] { 0,1,2,2,3,0,4,2},2,5,new int[]{0,1,0,0,3,0,4,0 })]
    
    public void Remove_Element_Is_Succeed_Case(int[] nums, int m,int result, int[] expectedResult)
    {
        var res=Solution.RemoveNumbers(nums,m);
       // Assert.IsTrue(nums.SequenceEqual(expectedResult));
        Assert.AreEqual(result,res);
    }
}