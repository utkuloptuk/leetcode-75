using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._413_aritmatic_slides;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new int[] {1,2,3,4},3)]
    [DataRow(new int[] {1},0)]

    
    public void aritmetic_slices_correct(int[] number,int expectedResult)
    {
        var result = Solution.NumberOfArithmeticSlices(number);
        Assert.AreEqual(expectedResult, result);
    }
}