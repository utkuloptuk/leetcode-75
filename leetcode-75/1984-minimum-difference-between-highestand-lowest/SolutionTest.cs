using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1984_minimum_difference_between_highestand_lowest;
[TestClass]
public class SolutionTest
{

        [TestMethod]
        [DataRow(new int[] { 90}, 1,0)]
        [DataRow(new int[] { 9,4,1,7}, 2,2)]
        public void FindDifference_is_Succeed(int[] nums,int target, int excepted_result)
        {
            var result = Solution.MinimumDifference(nums,target);
            Assert.AreEqual(result, excepted_result);
        }
    
}