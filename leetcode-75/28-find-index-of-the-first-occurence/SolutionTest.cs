using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._28_find_index_of_the_first_occurence;

[TestClass]
public class SolutionTest
{
    [TestMethod]
    [DataRow("sadbutsad", "sad",0)] 
    [DataRow("leetcode","leeto",-1)]
    [DataRow("mississippi","issip",4)]
    [DataRow("babba","bbb",-1)]
    [DataRow("aabaaabaaac","aabaaac",4)]
    
    public void Find_index_of_the_first_Is_Succeed_Case(string haystack, string needle,int expectedResult)
    {
        var res=Solution.StrStr(haystack,needle);
        // Assert.IsTrue(nums.SequenceEqual(expectedResult));
        Assert.AreEqual(expectedResult,res);
    }
}