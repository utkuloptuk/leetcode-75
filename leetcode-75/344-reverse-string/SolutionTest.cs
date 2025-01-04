using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._344_reverse_string;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow(new char[]{'h','e','l','l','o'},new char[]{'o','l','l','e','h'})]
    [DataRow(new char[]{'H','a','n','n','a','h'},new char[]{'h','a','n','n','a','H'})]
    
    public void move_zeros_succeed(char[] s,char[] expectedResult)
    {
        Solution.ReverseString(s);
        Assert.IsTrue(s.SequenceEqual(expectedResult));
    }
}