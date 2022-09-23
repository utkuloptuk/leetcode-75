
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._152_maximum_product_subarray
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 2, 3, -2, 4 }, 6)]
        [DataRow(new int[] { -2, 0, -1 }, 0)]
        [DataRow(new int[] {-2},-2)]
        [DataRow(new int[] { 0,2 }, 2)]
        [DataRow(new int[] { 3,-1,4 }, 4)]
        [DataRow(new int[] {2,-5,-2,-4,3}, 24)]
        public void Is_Maximum_SubArray_Multiply(int[] inputArr, int expectedResult)
        {
            var result = Solution.MaximumSubArrayMultiply(inputArr);
            Assert.AreEqual (expectedResult,result);
        }
    }
}
