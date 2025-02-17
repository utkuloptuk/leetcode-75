namespace leetcode_75._165_compare_version_numbers;

public static class Solution
{
    public static int CompareVersion(string version1, string version2) {
        //Leetcode onerilen kısmı time comp:O(m+n) memory O(1) 
        // var i = 0;
        // var j = 0;
        // while (i < version1.Length || j < version2.Length){
        //     var chunkVersion1 = 0;
        //     var chunkVersion2 = 0;
        //     while (i < version1.Length && version1[i] != '.'){
        //         chunkVersion1 = chunkVersion1 * 10 + (version1[i] - '0');
        //         i++;
        //     }
        //     while (j < version2.Length && version2[j] != '.'){
        //         chunkVersion2 = chunkVersion2 * 10 + (version2[j] - '0');
        //         j++;
        //     }
        //     if (chunkVersion1 != chunkVersion2){
        //         return chunkVersion1 < chunkVersion2 ? -1 : 1;
        //     }
        //     i++;
        //     j++;
        // }
        //
        // return 0;
        
        //Time comp:O(m+n) memory O(n)
        //string parsingler sanırım biraz zaman alıyor
        List<int> version1Numbers = version1.Split('.').Select(int.Parse).ToList();
        List<int> version2Numbers = version2.Split('.').Select(int.Parse).ToList();
        int v1=version1Numbers.Count;
        int v2=version2Numbers.Count;
        if (version1Numbers.Count > version2Numbers.Count)
        {
            for (int i = v2 - 1; i < v1; i++)
            {
                version2Numbers.Add(0);
            }
        }
        if (version1Numbers.Count < version2Numbers.Count)
        {
            for (int i = v1 - 1; i < v2; i++)
            {
                version1Numbers.Add(0);
            }
        }
        int min = Math.Min(version1Numbers.Count, version2Numbers.Count);
        for (int i = 0; i < min; i++)
        {
            if(version1Numbers[i] < version2Numbers[i])
                return -1;
            if(version1Numbers[i] > version2Numbers[i])
                return 1;
        }
        
        return 0;
    }
}