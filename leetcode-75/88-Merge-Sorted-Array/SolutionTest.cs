using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._88_Merge_Sorted_Array;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,2,3,0,0,0},3,new int[] {2,5,6 },3, new int[] { 1,2,2,3,5,6})]
    [DataRow(new int[] { 0},0,new int[] {1},1, new int[] { 1 })]
    [DataRow(new int[] { 1},1,new int[] { },0, new int[] { 1 })]
    public void Merge_Sorted_Is_Succeed_Case(int[] num1, int m,int[] num2,int n, int[] expectedResult)
    {
        Solution solution = new Solution();
        solution.Merge_Sorted_Array(num1, n,num2, m);
        Assert.IsTrue(num1.SequenceEqual(expectedResult));
    }
}