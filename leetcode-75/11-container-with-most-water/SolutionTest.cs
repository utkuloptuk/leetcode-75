using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._11_container_with_most_water;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{1,8,6,2,5,4,8,3,7},49)]
    [DataRow(new int[]{1,1},1)]
    [DataRow(new int[]{1,2,1},2)]
    [DataRow(new int[]{1,2,4,3},4)]
    
    public void max_water_succeed(int[] list,int expectedResult)
    {
        var result=Solution.MaxArea(list);
        Assert.AreEqual(result,expectedResult);    
        // Assert.IsTrue(s.SequenceEqual(expectedResult));
    }
}