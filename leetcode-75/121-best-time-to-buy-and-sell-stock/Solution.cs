
namespace leetcode_75._121_best_time_to_buy_and_sell_stock
{
    public static class Solution
    {
        public static int BestTimetoBuySellStock(int[] transactions)
        {
            int lPointer = 0;
            int rPointer = 1;
            int maxProfit = 0;
            while (rPointer < transactions.Length)
            {
                int profit = transactions[rPointer] - transactions[lPointer];
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
                if (transactions[rPointer] < transactions[lPointer])
                {
                    lPointer = rPointer;
                }
                rPointer++;
            }
            return maxProfit;
        }
    }
}
