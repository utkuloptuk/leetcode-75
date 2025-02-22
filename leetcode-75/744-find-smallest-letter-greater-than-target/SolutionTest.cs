using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._744_find_smallest_letter_greater_than_target;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new char[]{'c','f','j'},'a','c')]
    [DataRow(new char[]{'c','f','j'},'c','f')]
    [DataRow(new char[]{'x','x','y','y'},'z','x')]
    
    public void find_smallest_letter_correct(char[] number,char target,char expectedResult)
    {
        var result = Solution.NextGreatestLetter(number,target);
        Assert.AreEqual(expectedResult, result);
    }
}