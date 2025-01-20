namespace leetcode_75._75_sort_colors;

public static class Solution
{
    public static void SortColors(int[] nums) {
        //BucketSort kullan (hangisinden kactane var bulup sonra sıra ile lsiteye yaz.)
        Dictionary<int, int> colors = new Dictionary<int, int> ();
        foreach (var num in nums)
        {
            if(!colors.ContainsKey(num))
                colors.Add(num, 1);
            else
            {
                colors[num]++;
            }
        }
        List<int> sorted = new List<int>();
        int index = 0;
        while (index<3)
        {
            if (colors.ContainsKey(index)&&colors[index] > 0)
            {
                sorted.Add(index);
                colors[index]--;
            }
            else
            {
                index++;
            }
        }

        for (int i = 0; i < sorted.Count; i++)
        {
            nums[i] = sorted[i];
        }
        //burada 0 gürdüğümde başa 2 gordugumde sona dizecek olursam sanki hepsini dizmiş olurumç
        //eğer soldan baslayacaksam her 0 geldiğinde indexi bir geriye kaydırmalıyım.
        //Not: tam olarak calısmadı.4 casede index atladıgından 0 ile 1 in yerini degisitremedi
        // int lPointer = 0;
        // int rPointer = nums.Length - 1;
        // List<int> colors = nums.ToList();
        // int sayac = 0;
        // if (nums.Length == 2)
        // {
        //     if(nums[0] >= nums[1])
        //         (nums[0] , nums[1]) = (nums[1], nums[0]);
        // }
        // while (sayac<nums.Length-1)
        // {
        //     if (nums[sayac] == 0)
        //     {
        //        (nums[sayac], nums[lPointer]) = (nums[lPointer], nums[sayac]);
        //         lPointer++;
        //     }
        //
        //     if (nums[sayac] == 2&&sayac<rPointer)
        //     {
        //         (nums[sayac], nums[rPointer]) = (nums[rPointer], nums[sayac]);
        //         rPointer--;
        //
        //     }
        //     if (nums[sayac] != 2||nums[sayac] != 0)
        //         sayac++;
        // }
    }
}