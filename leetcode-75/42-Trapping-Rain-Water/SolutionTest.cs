using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._42_Trapping_Rain_Water;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 0,1,0,2,1,0,1,3,2,1,2,1 },6)]
    [DataRow(new int[] { 4,2,0,3,2,5 }, 9)]
    public void filled_water_is_succeed(int[] inputArr, int expectedResult)
    {
        var result = Solution.Trap(inputArr);
        Assert.AreEqual(expectedResult, result);
    }
}