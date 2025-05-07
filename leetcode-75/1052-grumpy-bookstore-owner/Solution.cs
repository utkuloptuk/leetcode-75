namespace leetcode_75._1052_grumpy_bookstore_owner;

public class Solution
{
    public static int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        //sliding window 
        int n = customers.Length;
        int baseSatisfied = 0;
    
        // Calculate base satisfied customers without using the technique
        for (int i = 0; i < n; i++) {
            if (grumpy[i] == 0) {
                baseSatisfied += customers[i];
            }
        }
    
        int maxAdditional = 0;
        int currentAdditional = 0;
    
        // Initialize the first window (0 to minutes-1)
        for (int i = 0; i < minutes; i++) {
            if (grumpy[i] == 1) {
                currentAdditional += customers[i];
            }
        }
        maxAdditional = currentAdditional;
    
        // Slide the window from minutes to n-1
        for (int i = minutes; i < n; i++) {
            int left = i - minutes; // Leftmost element exiting the window
            if (grumpy[left] == 1) {
                currentAdditional -= customers[left];
            }
            if (grumpy[i] == 1) { // New element entering the window
                currentAdditional += customers[i];
            }
            maxAdditional = Math.Max(maxAdditional, currentAdditional);
        }
    
        return baseSatisfied + maxAdditional;
        // int total = 0;
        // if(customers.Length==1)
        //     return customers[0];
        // for (int i = 0; i < customers.Length; i++)
        // {
        //     if(grumpy[i] == 0)
        //         total += customers[i];
        // }
        //
        // int maxtotal = total;
        // int clicker=minutes-1;
        // for (int i = clicker; i < customers.Length; i++)
        // {
        //     if (grumpy[i-clicker] == 1)
        //         total -= customers[i-clicker];
        //     if (grumpy[i] == 1)
        //         total += customers[i];
        //     maxtotal = Math.Max(maxtotal, total);
        // }
        // return maxtotal;
        //bruteforce On2
        // int total = 0;
        // for (int i = 0; i < customers.Length; i++)
        // {
        //     if (grumpy[i] == 0)
        //         total += customers[i];
        // }
        // int highest = 0;
        // for (int i = 0; i <= customers.Length - minutes; i++)
        // {
        //     int realNumber=0;
        //     int dialetedNumber = 0;
        //     for (int j = i; j < i + minutes; j++)
        //     {
        //         if (grumpy[j] == 0)
        //             realNumber+=customers[j];
        //         dialetedNumber+=customers[j];
        //     }
        //     highest=Math.Max(highest,dialetedNumber-realNumber);
        // }
        //
        // return total+highest;
    }
}