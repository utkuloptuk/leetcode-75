using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._31_next_permutation;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 },  new int[] { 1,3,2 })]
    [DataRow(new int[] { 3,2,1 },  new int[] { 1,2,3})]
    [DataRow(new int[] { 1,1,5 },  new int[] { 1,5,1})]
    [DataRow(new int[] { 1},  new int[] { 1})]
    [DataRow(new int[] { 1,1},  new int[] { 1,1})]
    [DataRow(new int[] { 1,3,2},  new int[] {2,1,3})]
    public void Next_Permutation_Is_Succeed_Case(int[] num1,  int[] expectedResult)
    {
        Solution.NextPermutation(num1);
        Assert.IsTrue(num1.SequenceEqual(expectedResult));
    }
}