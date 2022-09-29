
namespace leetcode_75._15_3sum
{
    public static class Solution
    {
        public static int[][] ThreeSum(int[] inputArray)
        {
            int left = 0;
            int length = inputArray.Length;
            int right = length - 1;
            int counter = 0;
            int[][] resultList = new int[][] { };
            Array.Sort(inputArray);
            for (int i = 0; i < length; i++)
            {
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
                        resultList.Append(appValue);
                        counter++;
                        break;
                    }
                }
                left = 0;
                length = inputArray.Length;
            }


            return resultList;
        }
    }
}
