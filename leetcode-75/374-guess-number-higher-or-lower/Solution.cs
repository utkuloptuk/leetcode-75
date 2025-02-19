namespace leetcode_75._374_guess_number_higher_or_lower;

public class Solution
{
    public int GuessNumber(int n) {
        int first=0;
        int last = n;
        while (first <= last)
        {
            int mid = first+(last- first) / 2;
            if(guess(mid)==-1)
                last = mid-1;
            else if(guess(mid)==1)
                first = mid+1;
            else
                return Convert.ToInt32(mid);
        }

        return 1;
    }

    public int guess(int mid)
    {
        return 0;
    }
}