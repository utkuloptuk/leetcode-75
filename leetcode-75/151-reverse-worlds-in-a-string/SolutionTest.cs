using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._151_reverse_worlds_in_a_string;
[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("IceCreAm", "AceCreIm")]
    [DataRow("leetcode", "leotcede")]
    [DataRow("a.", "a.")]
    public void reverse_string_succeed(string s, string expectedResult)
    {
    }
}