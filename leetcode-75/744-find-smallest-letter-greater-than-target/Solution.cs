namespace leetcode_75._744_find_smallest_letter_greater_than_target;

public static  class Solution
{
    public static char NextGreatestLetter(char[] letters, char target)
    {
        int comprasionCount = 30;
        char result =letters[0];
        if(target=='z')
            return letters[0];
        for (int i = 0; i < letters.Length; i++)
        {
            int dif=letters[i] - target;
            if (comprasionCount >= dif&&dif>0)
            {
                comprasionCount = dif;
                result = letters[i];
            }
        }
        return result;
    }
}