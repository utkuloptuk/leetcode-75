using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._350_intersection_of_two_arrays_2;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{1,2,2,1},new int[]{2,2}, new int[]{2,2})]
    // [DataRow(new int[]{4,9,5},new int[]{9,4,9,8,4}, new int[]{9,4})]
    [DataRow(new int[]{4,9,5},new int[]{9,4,9,8,4}, new int[]{4,9})]

    
    public void intersection_succeed(int[] num1, int[] num2,int[] expectedResult)
    {
        var result =Solution.Intersect(num1, num2);
        Assert.IsTrue(result.SequenceEqual(expectedResult));
    }
}