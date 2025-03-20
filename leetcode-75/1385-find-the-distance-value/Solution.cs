namespace leetcode_75._1385_find_the_distance_value;

public static class Solution
{
    public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
    {
        Array.Sort(arr2);
        int index = 0;
        
        for (int i = 0; i < arr1.Length; i++)
        {
            int process=arr1[i];
            int first = 0;
            int last=arr2.Length-1;
            bool found=true;
            while (first <= last)
            {
                int mid = (first + last) / 2;
                if (Math.Abs(arr2[mid] - process) <= d)
                {
                    found=false;
                    break;
                }
                if (arr2[mid]<process)
                {
                    first = mid+1;
                }
                else
                    last = mid-1;
            }
            if(found)
                 index++;
        }

        return  index;

    }
}