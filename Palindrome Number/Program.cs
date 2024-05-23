// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.IsPalindrome(121));


public class Solution
{
    public static bool IsPalindrome(int x)
    {
        int lastPower = (int)Math.Log10(x);
        while (lastPower != 1)
        {
            if(x / (lastPower * 10) != x % 10)
                return false;
            lastPower --;
            x /= 10;
            x %= lastPower * 10; 
        }

        return true;
    }
}
