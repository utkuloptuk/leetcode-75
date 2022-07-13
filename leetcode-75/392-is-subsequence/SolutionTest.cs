
namespace leetcode_75._392_is_subsequence
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow("abc","ahbgdc",true)]
        [DataRow("axc","ahbgdc",false)]

        public void Subsequence_is_Succeed(string s, string t, bool excepted_value)
        {
            var result = Solution.IsSubsequence(s,t);
            Assert.AreEqual(result, excepted_value);
        }
    }
}
