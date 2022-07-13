
namespace leetcode_75._724_find_pivot_index
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [DataRow(new int[] { 1, 2, 3 }, -1)]
        [DataRow(new int[] { 2, 1, -1 }, 0)]
        [DataRow(new int[] { -1, -1, 0, 1, 1, 0 }, 5)]
        public void FindPivotIndex_is_Succeed(int[] nums, int excepted_result)
        {
            var result = Solution.PivotIndex(nums);
            Assert.AreEqual(result, excepted_result);
        }
    }
}
