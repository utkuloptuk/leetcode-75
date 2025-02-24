namespace leetcode_75._1337_the_k_weakest_rows_in_matrix;

public static class Solution
{
    public static int[] KWeakestRows(int[][] mat, int k) {
        Dictionary<int, int> counts = new Dictionary<int, int>();
        for (int i = 0; i < mat.Length; i++)
        {
            int total = 0;
            total=countSoldier(mat[i]);
            //Sum methodu yerine binary search ile time complexityden zaman kazanıldı.
            // total=mat[i].Sum();
            counts.Add(i,total);
        }
        var result = counts.OrderBy(x=>x.Value).Take(k).ToList();
        int[] resultArray = new int[k];
        for (int i = 0; i < result.Count(); i++)
        {
            resultArray[i]=result[i].Key;
        }
        return resultArray;
    }

    public static int countSoldier(int[] row)
    {
        int left = 0;
        int right = row.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (row[mid] == 1)
                left = mid + 1;
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }
}