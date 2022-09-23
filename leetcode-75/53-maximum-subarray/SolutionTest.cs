using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._53_maximum_subarray
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 },6)]
        [DataRow(new int[] { 1 }, 1)]
        [DataRow(new int[] { 5, 4, -1, 7, 8 }, 23)]
        [DataRow(new int[] { -1}, -1)]
        public void Is_Maximum_SubArray_Elements_Sum(int[] inputArr, int expectedResult)
        {
            var result = Solution.Maximum_SubArray_Sum(inputArr);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
