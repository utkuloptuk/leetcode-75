
namespace leetcode_75._205_isomorphic_strings
{
    public static class Solution
    {
        public static bool IsIsomorphic(string s, string t)
        {
            //Timeout problem
            int sLength = s.Length;
            int tLength = t.Length;
            var sCharArray = s.ToCharArray();
            var tCharArray = t.ToCharArray();
            bool result = true;
            if (!sLength.Equals(tLength))
            {
                return false;
            }
            for (int i = 0; i < sLength; i++)
            {
                if (s.Count(x => x.Equals(sCharArray[i]))
                .Equals(t.Count(x => x.Equals(tCharArray[i]))))
                {
                    if (!AllIndexesOf(s, sCharArray[i].ToString())
                        .SequenceEqual(AllIndexesOf(t, tCharArray[i].ToString())))
                    {
                        result = false;
                    }
                }
                else
                    result = false;
            }
            return result;

        }
        public static IEnumerable<int> AllIndexesOf( string str, string searchstring)
        {
            int minIndex = str.IndexOf(searchstring);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = str.IndexOf(searchstring, minIndex + searchstring.Length);
            }
        }
    }
}
