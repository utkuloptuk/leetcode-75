using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_75._33_search_in_rotated_sorted_array
{
    public static class Solution
    {
        public static int FindIndex(int[] inputArray, int target)
        {
            int result = -1;
            int left = 0;
            int mid = (inputArray.Length - 1) / 2;
            int right = inputArray.Length - 1;

            while (left <= right)
            {
                if (inputArray[mid].Equals(target))
                {
                    result = mid;
                    break;
                }
                if (inputArray[left].Equals(target))
                {
                    result = left;
                    break;
                }
                if (inputArray[right].Equals(target))
                {
                    result = right;
                    break;
                }
                if (inputArray[mid] >= inputArray[left] )
                {
                    if (target > inputArray[mid] || (target < inputArray[left] && target < inputArray[right]))
                    {
                        left = mid+1;
                        mid++;
                    }
                    else
                    {
                        right = mid-1;
                        mid--;
                    }
                }
                else
                {
                    if (target < inputArray[mid] || (target > inputArray[right] && target> inputArray[left]))
                    {
                        right = mid-1;
                        mid--;
                    }
                    else
                    {
                        left = mid + 1;
                        mid++;
                    }
                }
            }
            return result;
        }
    }
}
