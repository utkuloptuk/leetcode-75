

namespace leetcode_75._121_best_time_to_buy_and_sell_stock
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SolutionTest
    {
        [TestMethod]
        [DataRow(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [DataRow(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void best_time_best_sell_max_profit_is_correct(int[] transactionList, int maxProfit)
        {
            var result = Solution.BestTimetoBuySellStock(transactionList);
            Assert.AreEqual(maxProfit, result);
        }
    }
}
