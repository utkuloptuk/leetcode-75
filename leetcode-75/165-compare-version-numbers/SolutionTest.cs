using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace leetcode_75._165_compare_version_numbers;
[TestClass]
public class SolutionTest
{
    [TestMethod] 
    [DataRow("1.2", "1.10", -1)] 
    [DataRow("1.01", "1.001", 0)] 
    [DataRow("1.0", "1.0.0.0", 0)]
    [DataRow("1.0.1", "1", 1)]
    [DataRow("7.5.2.4", "7.5.3", -1)]
    [DataRow("1", "1.1", -1)]

    public void compared_versions_is_correct(string number1, string number2, int expected)
    {
        var result = Solution.CompareVersion(number1, number2);
        Assert.AreEqual(expected, result);
    }
}