namespace leetcode_75._436_find_right_interval;

public class Solution
{
    public int[] FindRightInterval(int[][] intervals)
    {
        int length = intervals.Length;
        var indexedIntervals = intervals.Select((interval, index) => (interval[0], interval[1], index)).ToArray();
        Array.Sort(indexedIntervals,(a,b)=>a.Item1.CompareTo(b.Item1));
        int[] result = new int[length];

        for (int i = 0; i < length; i++)
        {
            int end=intervals[i][1];
            int left = 0;
            int right = length-1;
            int index = -1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                if (indexedIntervals[middle].Item1 >= end)
                {
                    index = indexedIntervals[middle].Item3;
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }

                result[i] = index;
            }
        }
        return result;
        //don't work
        // int subarrayLength = intervals.Length;
        // int first = 1;
        // List<int> result = new List<int>(){-1};
        // while (first < subarrayLength)
        // {
        //
        //     if (first > 0 && intervals[first][1] <= intervals[first - 1][0])
        //         result.Add(first-1);
        //     else if (first < subarrayLength - 1 && intervals[first][1] >= intervals[first + 1][0])
        //         result.Add(first+1);
        //     else
        //         result.Add(-1);
        //     first++;
        // }
        //
        // return result.ToArray();
    }
}