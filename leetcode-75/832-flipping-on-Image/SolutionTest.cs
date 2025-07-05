using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._832_flipping_on_Image;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    public void ThreeSum_is_Succeed_Case_1()
    {
        int[][] req = new int[][] { new int[] { 1,1,0} , new int[] { 1,0,1},new int[] { 0,0,0}  };
        int[][] res = new int[][] {new int[] { 1,0,0},new int[] { 0,1,0},new int[] { 1,1,1} };
        var result = Solution.FlipAndInvertImage(req);
        Assert.AreEqual(res, result);
    }
}