namespace leetcode_75._1346_check_if_n_and_its_double;

public static class Solution
{
    public static bool CheckIfExist(int[] arr)
    {
        //note : kücük datasetlerde brute force method daha perfoırmanslı calısıyor
         Array.Sort(arr);

        for (int i = 0; i < arr.Length; i++)
        {
            int first = 0;
            int target=arr[i]*2;
            int last = arr.Length-1;
            while (first <=last)
            {
                int mid = (first+last) / 2;
                if(target == arr[mid]&&mid!=i)
                    return true;
                if(target< arr[mid])
                    last = mid - 1;
                else
                    first = mid + 1;
            }
        }
        return false;
    }
}