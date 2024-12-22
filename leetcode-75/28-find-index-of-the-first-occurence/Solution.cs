namespace leetcode_75._28_find_index_of_the_first_occurence;

public static class Solution
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length-needle.Length; i++)
        {
            if (haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
            
        }

        return -1;
    }
    /* failed version
     public static int StrStr(string haystack, string needle)
      {
          int slowPointer = 0;
          int startIndex = 0;
          List<int> shadowStartIndex=new List<int>(){0};

          int neddleCount = needle.Length;
          int haystackLength = haystack.Length;
          for (int highPointer = 0; highPointer < haystackLength; highPointer++)
          {
              if (haystack[highPointer] == needle[slowPointer] && neddleCount == 1)
                  return highPointer;
              if (haystack[highPointer] == needle[0]&&haystack[highPointer+1] == needle[1])
                  shadowStartIndex.Add(highPointer);
              if (haystack[highPointer] == needle[slowPointer])
              {
                  if (slowPointer == 0)
                      startIndex = highPointer;
                  slowPointer++;
              }
              else
                  slowPointer = 0;
              if (highPointer == 0)
                  continue;
              int shadowIndexLength=shadowStartIndex.Count;
              if (haystack[highPointer-1] == needle[highPointer-shadowStartIndex[shadowIndexLength-1]] && slowPointer == 0)
              {

                  startIndex = shadowStartIndex.Last();
                  slowPointer=highPointer-shadowStartIndex.Last();
              }
              if (slowPointer == neddleCount)
                  return startIndex;
          }
          return -1; 
    }*/
}