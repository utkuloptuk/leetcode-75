using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._75_sort_colors;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 2,0,2,1,1,0},  new int[] { 0,0,1,1,2,2 })]
    [DataRow(new int[] {2,0,1},  new int[] { 0,1,2})]
    [DataRow(new int[] {1,0},  new int[] { 0,1})]
    [DataRow(new int[] {1,2,0},  new int[] { 0,1,2})]

    public void sort_succeed(int[] num1, int[] expectedResult)
    {
      Solution.SortColors(num1);
      CollectionAssert.AreEqual(expectedResult, num1);
      
    }
}