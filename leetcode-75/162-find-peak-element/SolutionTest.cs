using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._162_find_peak_element;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 1 }, 2)]
    [DataRow(new int[] { 1,2,1,3,5,6,4}, 5)]
    public void find_peak_element_is_succeed(int[] list, int expectedResult)
    {
        var result = Solution.FindPeakElement(list);
        Assert.AreEqual(expectedResult, result);

    }
}