namespace leetcode_75._202_happy_number;

public class Solution
{
    public static bool HappyNumber(int n)
    {
        //efficient-reasonable  solution time complexityO(n)
        HashSet<int> hash = new();
        while (!hash.Contains(n))
        {
            hash.Add(n);
            if(n==1)
                return true;
            n = sumOfDigitsSquare(n);
        }
        return false;

        //my solution time complexity=O(lognxd)
        // string s = n.ToString();
        // int sum = 0;
        // List<int> list = new List<int>();
        // while (sum != 1)
        // {
        //     if( sum!=0)
        //         s=sum.ToString();
        //     sum = 0;
        //     for (int i = 0; i <= s.Length - 1; i++)
        //     {
        //         sum += int.Parse(s[i].ToString())* int.Parse(s[i].ToString());
        //         
        //     }
        //     if (list.Contains(sum))
        //         return false;
        //     list.Add(sum);
        //
        // }
        // return true;

    }

    private static int sumOfDigitsSquare(int n)
    {
        int sum = 0;
        int digit = 0;
        while (n>0)
        {
            digit=n % 10;
            n = n / 10;
            sum += digit*digit;
        }
        return sum;
    }
}