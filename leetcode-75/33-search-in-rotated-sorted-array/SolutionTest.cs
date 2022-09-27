
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._33_search_in_rotated_sorted_array
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        [DataRow(new int[] { 1 }, 0, -1)]
        [DataRow(new int[] { 3, 5, 1 }, 3, 0)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 5, 1)]
        [DataRow(new int[] { 8, 1, 2, 3, 4, 5, 6, 7 }, 6, 6)]
        [DataRow(new int[] { 4,5,6,7,8,9,1,2,3 }, 1, 6)]
        [DataRow(new int[] { 8,9,2,3,4 }, 9, 1)]
        public void Find_Number_Index_is_Succeed(int[] inputArray, int target, int expectedResult)
        {
            var result = Solution.FindIndex(inputArray, target);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
