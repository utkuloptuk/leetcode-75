namespace leetcode_75._832_flipping_on_Image;

public static class Solution
{
    public static int[][] FlipAndInvertImage(int[][] image) {

        for (int y = 0; y < image.Length; y++)
        {
            image[y]=ReverseArray(image[y]);
        }
        return image;
    }

    private static int[] ReverseArray(int[] array)
    {
        int[] result = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            result[i]=reverseObject(array[array.Length-1-i]);
        }

        return result;
    }

    private static int reverseObject(int i)
    {
        return i == 0 ? 1 : 0;
    }
}