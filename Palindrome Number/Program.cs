// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.IsPalindrome(121));
public class Solution
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0)
            return false;
        if (x / 10 == 0)
            return true;

        byte power = (byte)Math.Log10(x);
        int right = (x % 10);
        byte left = (byte)(x / Math.Pow(10, power));
        double mid = power / 2.0;
        for (int i = 0; i < mid; i++)
        {
            if (left != right)
                return false;
            x /= 10;
            right = (x % 10);
            power -= 2;
            left = (byte)(x / Math.Pow(10, power) % 10);
        }
        return true;
    }
}
