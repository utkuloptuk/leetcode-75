using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._541_reverse_string_2;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("abcdefg",2,"bacdfeg")]
    [DataRow("abcd",2,"bacd")]
    [DataRow("abcdef",3,"cbadef")]
    [DataRow("a",2,"a")]
    [DataRow("abcdefg",3 ,"cbadefg")]

    public void reverse_string_succeed(string s,int i,string expectedResult)
    {
        var result =Solution.ReverseStr(s,i);
        Assert.AreEqual(expectedResult, result);
    }
}