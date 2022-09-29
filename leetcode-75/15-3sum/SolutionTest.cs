using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._15_3sum
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        public void ThreeSum_is_Succeed_Case_1()
        {
            int[][] res = new int[][] { new int[] { -1, -1, 2 }, new int[] { -1, 0, 1 } };
            int[] req = new int[] { -1, 0, 1, 2, -1, -4 };
            var result = Solution.ThreeSum(req);
            Assert.AreEqual(res, result);
        }
        [TestMethod]
        public void ThreeSum_is_Succeed_Case_2()
        {
            int[][] res = new int[][] { };
            int[] req = new int[] { 0, 1, 1 };
            var result = Solution.ThreeSum(req);
            Assert.AreEqual(res, result);
        }
        [TestMethod]
        public void ThreeSum_is_Succeed_Case_3()
        {
            int[][] res = new int[][] { new int[] { 0, 0, 0 } };
            int[] req = new int[] { 0, 0, 0 };
            var result = Solution.ThreeSum(req);
            Assert.AreEqual(res, result);
        }
    }
}
