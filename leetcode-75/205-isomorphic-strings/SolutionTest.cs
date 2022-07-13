

namespace leetcode_75._205_isomorphic_strings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow("egg","add",true)]
        [DataRow("foo","bar",false)]
        [DataRow("paper","title",true)]
        public void IsomorphicStrings_are_Succeed(string s, string t, bool excepted_value)
        {
            var result = Solution.IsIsomorphic(s,t);
            Assert.AreEqual(excepted_value,result);
        }
    }
}
