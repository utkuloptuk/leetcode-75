using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._1346_check_if_n_and_its_double;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] { 10,2,5,3}, true)]
    [DataRow(new int[] { 3,1,7,11 }, false)]
    [DataRow(new int[] { 7,1,14,11}, true)]
    [DataRow(new int[] { -10,12,-20,-8,15}, true)]
    [DataRow(new int[] { -2,0,10,-19,4,6,-8}, false)]
    [DataRow(new int[] { 0,0}, true)]
    public void RunnigSum_Method_is_Succeed(int[] numbs, bool excepted_result)
    {
        var result=Solution.CheckIfExist(numbs);
        Assert.AreEqual(excepted_result, result);
    }
}