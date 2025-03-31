using System.Collections;

namespace leetcode_75._378_kth_smallest_element;

public static class Solution
{
    public static int KthSmallest(int[][] matrix, int k)
    {

        int left = matrix[0][0];
        int right = matrix[^1][matrix[0].Length - 1];
        while (left < right)
        {
            int middle = left + (right - left) / 2;
            int count = Counter(matrix, middle);
            if (count < k)
            {
                left = middle + 1;
            }
            else
            {
                right = middle;
            }
        }
        return left;
        //not efficient version
        // List<int> arrayList  = new List<int>();
        // foreach (var t in matrix)
        // {
        //     foreach (var t1 in t)
        //     {
        //         arrayList.Add(t1);
        //     }
        // }
        // arrayList.Sort();
        // return arrayList[k-1];
    }

    public static int Counter(int[][] matrix, int k)
    {
        int arrayLength = matrix.Length;
        int elementLength = matrix[0].Length ;
        int counter = 0;
        int first = 0; int last = elementLength - 1; 
        while (arrayLength > first && last >=0 )
        {
            if (matrix[first][last] <= k)
            {
                counter+=last+1;
                first++;
            }
            else
            {
                last--;
            }
        }
        return counter;
    }
}