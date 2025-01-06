using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75.intersection_of_two_arrays;

[TestClass]
public class SolutionTest
{
    [TestMethod]
     [DataRow(new int[]{1,2,2,1},new int[]{2,2}, new int[]{2})]
    // [DataRow(new int[]{4,9,5},new int[]{9,4,9,8,4}, new int[]{9,4})]
    [DataRow(new int[]{9,3,7},new int[]{6,4,1,0,0,4,4,8,7}, new int[]{7})]
     [DataRow(new int[]{1},new int[]{1}, new int[]{1})]
    [DataRow(new int[]{3,1,2},new int[]{1}, new int[]{1})]
    
    public void intersection_succeed(int[] num1, int[] num2,int[] expectedResult)
    {
        var result =Solution.Intersection(num1, num2);
        Assert.IsTrue(result.SequenceEqual(expectedResult));
    }
}