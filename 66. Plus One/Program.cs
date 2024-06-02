public class Solution
{
    public static int[] PlusOne(int[] digits)
    {
        int c = 0;
        digits[digits.Length - 1]++;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (c != 0)
                digits[i]++;
            c = digits[i] / 10;
            if (c == 0)
                return digits;
            digits[i] = 0;
        }

        int[] res = new int[digits.Length + 1];
        for (int i = 1; i < res.Length; i++)
            res[i] = 0;
        res[0] = 1;
        return res;

    }
}