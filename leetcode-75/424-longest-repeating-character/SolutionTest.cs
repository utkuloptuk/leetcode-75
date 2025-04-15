using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._424_longest_repeating_character;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("ABAB", 2,4)]
    [DataRow("AABABBA", 1,4)]
    [DataRow("AAAA", 2,4)]
    [DataRow("AAAB", 0,3)]
    [DataRow("ABBB", 2,4)]//bu ornek benim kodu patlattı.

    public void coin_arrange_is_Succeed(string text,int k, int expected)
    {
        var result=Solution.CharacterReplacement(text, k);
        Assert.AreEqual(expected, result);
    }
}