
namespace leetcode_75._1480_running_sum_1d_array
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [DataRow(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [DataRow(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunnigSum_Method_is_Succeed(int[] numbs, int[] excepted_result)
        {
            var result = Solution.RunningSum(numbs);
            Assert.IsTrue(result.SequenceEqual(excepted_result));

        }
    }
}
