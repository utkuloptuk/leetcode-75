namespace leetcode_75._1351_count_negative;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        //time comp=O(n*mlogn) memory=O(1)
        int count = 0;
        for (int row = 0; row < grid.Length; row++)
        {
            int first = 0;
            int last = grid[row].Length - 1;
            Array.Sort(grid[row]);
            while (first <= last)
            {
                int middle= (first + last) / 2;
                if (grid[row][middle] < 0)
                {
                    first=middle+1;
                }
               else
                {
                    last = middle - 1;
                }
            }
            count += first;
        }
        return count;
    }
}