using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1089_duplicated_zero;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1,0,2,3,0,4,5,0}, new int[] { 1,0,0,2,3,0,0,4 })]
      [DataRow(new int[] { 1,2,3}, new int[] { 1,2,3})]
    [DataRow(new int[] { 0,0,0,0,0,0,0}, new int[] { 0,0,0,0,0,0,0})]
    [DataRow(new int[] { 0,4,1,0,0,8,0,0,3}, new int[] { 0,0,4,1,0,0,0,0,8})]
    public void Duplicated_Zeros_is_Succeed(int[] numbs, int[] excepted_result)
    {
         Solution.DuplicateZeros(numbs);
        Assert.IsTrue(numbs.SequenceEqual(excepted_result));
    }
}