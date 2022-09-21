
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._217_contains_duplicate
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 1 }, true)]
        [DataRow(new int[] { 1, 2, 3, 4 }, false)]
        [DataRow(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void duplicate_contains_check_is_succeed(int[] list, bool expectedResult)
        {
            var result = Solution.CheckListForDuplicateRecord(list);
            Assert.AreEqual(expectedResult, result);

        }
    }
}
