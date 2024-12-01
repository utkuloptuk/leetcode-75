using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._338_counting_bits;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void CountingBitsTest_is_Succeed_Case_1()
    {
        int request = 2;
        int[] response = {0, 1, 1};
        var result = Solution.CountBits(request);
        Assert.AreEqual(response, result);
    }

    [TestMethod]
    public void CountingBitsTest_is_Succeed_Case_2()
    {
        int request = 5;
        int[] response = {0, 1, 1,2,1,2};
        var result = Solution.CountBits(request);
        Assert.AreEqual(response, result);
    }
}