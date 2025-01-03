using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._283_move_zeroes;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[]{0,1,0,3,12},new int[]{1,3,12,0,0})]
    [DataRow(new int[]{0},new int[]{0})]
    [DataRow(new int[]{1,0,1},new int[]{1,1,0})]
    
    public void move_zeros_succeed(int[] number,int[] expectedResult)
    {
        Solution.MoveZeroes(number);
        Assert.IsTrue(number.SequenceEqual(expectedResult));
    }
}