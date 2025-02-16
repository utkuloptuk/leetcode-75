namespace leetcode_75._278_first_bad_version;

// I cant write for this question because it has an inherit other class.
public class Solution
{


     public int FirstBadVersion(int n)
     {
          int first = 1;
          int last = n;
          int counter = 0;
          while (first <= last)
          {
               int middle = first + (last - first) / 2;
               if (/*!IsBadVersion(middle)*/true)
               {
                    first = middle + 1;
               }
               else
               {
                    counter = middle;
                    last = middle - 1;

               }
          }
          return counter;

     }
     
     //it should be work but it takes time exceeded for this example n=2126753390 bad=1702766719
     //     int first = 0;
     //     int last = n;
     //     int result = 0;
     //     while (first <= last)
     //     {
     //         int mid = first + (last - first) / 2;
     //         if (!IsBadVersion(mid))
     //         {
     //             first = mid;
     //         }
     //         else
     //         {
     //             result = mid;
     //             last = mid;
     //         }
     //     }
     //
     //     return result;
     // }
}
