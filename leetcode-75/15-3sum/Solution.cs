
namespace leetcode_75._15_3sum
{
    public static class Solution
    {
        public static int[][] ThreeSum(int[] inputArray)
        {
            int length = inputArray.Length;
            List<int[]> resultList = new List<int[]> { };
            Array.Sort(inputArray);
            for (int i = 0; i < length; i++)
            {
                int left = i+1;
                int right = length - 1;
                if (!i.Equals(0) && inputArray[i].Equals(inputArray[i - 1]))
                {
                    left++;
                    continue;
                }
                int firstVal = inputArray[i];
                while (left < right)
                {
                    var treeSum = firstVal + inputArray[left] + inputArray[right];
                    if (treeSum > 0)
                        right--;
                    else if (treeSum < 0)
                        left++;
                    else
                    {
                        var appValue = new int[] { firstVal, inputArray[left], inputArray[right] };
                        resultList.Add(appValue);
                        left++;
                        while (inputArray[left] == inputArray[left - 1] && left < right)
                            left++;
                    }
                }
            }
            return resultList.ToArray();
        }
    }
}
