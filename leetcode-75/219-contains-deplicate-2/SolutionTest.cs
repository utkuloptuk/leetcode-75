using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._219_contains_deplicate_2;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{1,2,3,1}, 3,true)]
    [DataRow(new int[]{1,0,1,1}, 1,true)]
    [DataRow(new int[]{1,2,3,1,2,3}, 2,false)]
    [DataRow(new int[]{99,99}, 2,true)]
    [DataRow(new int[]{1,2,1}, 1,false)]
    [DataRow(new int[]{0,1,2,3,2,5}, 3,true)]
    public void sqrt_is_correct(int[] numbs, int k,bool expectedResult)
    {
        var result = Solution.ContainsNearbyDuplicate(numbs,k);
        Assert.AreEqual(expectedResult, result);
    }
}