

namespace leetcode_75._1_two_sum
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        //[DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
        //[DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
        [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]

        public void Is_Two_Sum_Data_Index_Correct(int[] array, int target, int[] resultArray)
        {
            var result = Solution.TwoSumIndex(array, target);
            Assert.IsTrue(resultArray.SequenceEqual(result));

        }
    }
}
