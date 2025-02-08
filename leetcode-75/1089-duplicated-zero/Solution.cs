namespace leetcode_75._1089_duplicated_zero;

public static class Solution
{
    public static void DuplicateZeros(int[] arr)
    {
        var length=arr.Length;
        int i = 0;
        List<int> queue=new List<int>();
         while (i < length)
        {
            if (arr[i] == 0)
            {

                queue.Add(0);
                queue.Add(0);
                arr[i] = queue[0];
                queue.RemoveAt(0);
            }
            else
            {
                queue.Add(arr[i]); 
                arr[i] = queue[0];
                queue.RemoveAt(0);
            }

            i++;
        }
    }
}