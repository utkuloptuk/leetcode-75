using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._153_find_minimum_rotated_sorted_array
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 3, 4, 5, 1, 2 }, 1)]
        [DataRow(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0)]
        [DataRow(new int[] { 11, 13, 15, 17 }, 11)]

        public void Find_Minumum_Value_in_Sorted_Array_is_Succeed(int[] sortedArray, int expectedOutput)
        {
            var result = Solution.FindMinValue(sortedArray);
            Assert.AreEqual(expectedOutput,result);
        }
    }
}
