using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._238_product_of_array_except_self
{
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [DataRow(new int[] { -1, 1, 0, -3, 3 }, new int[] { 0, 0, 9, 0, 0 })]
        public void array_multiply_all_elements_except_self_is_succeed(int[] inputArray, int[] exceptedArray)
        {
            var result = Solution.ArrayElementsMultiplyExceptSelf(inputArray);
            Assert.IsTrue(result.SequenceEqual(exceptedArray));
        }
    }
}
