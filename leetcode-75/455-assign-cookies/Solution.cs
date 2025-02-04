namespace leetcode_75._455_assign_cookies;

public static class Solution
{
    public static int FindContentChildren(int[] g, int[] s) {
        //Time komp: O(nlogn+mlogm) memory O(1)
        Array.Sort(s);
        Array.Sort(g);
        int result = 0;
        int child = 0;
        int cookie = 0;
        while (s.Length>cookie&&g.Length>child)
        {
            if (s[cookie] >= g[child])
            {
                result++;
                child++;
            }
            cookie++;
        }
        return result;
        //Hatalı yaklasım.Her cookie her childrenle eslesiyor diye düşünmüştüm.Cookie cocuk aclıgından buytuk oldugu durumda da cookieyi alabilirmiş.
        // Dictionary<int,int> cookies = new Dictionary<int, int>();
        // HashSet<int> visited = new HashSet<int>(g);
        // int result = 0;
        // foreach (var cookie in s)
        // {
        //     if(!cookies.TryAdd(cookie, 1))
        //         cookies[cookie]++;
        // }
        //
        // foreach (int c in g)
        // {
        //     if (cookies.ContainsKey(c)&&cookies[c]>0)
        //     {
        //         result++;
        //         cookies[c]--;    
        //     }
        // }
        //
        // foreach (int c in visited)
        // {
        //     if(cookies.ContainsKey(c)&&cookies[c]>0&&c>cookies[c])
        //         result+=cookies[c];
        // }
        // return result;
    }
}