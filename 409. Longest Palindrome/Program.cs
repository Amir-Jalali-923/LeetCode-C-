System.Console.WriteLine(Solution.LongestPalindrome("abccccdd"));
public class Solution
{
    public static int LongestPalindrome(string s)
    {
        Dictionary<char, int> data = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (data.ContainsKey(c))
                data[c]++;
            else
                data[c] = 1;
        }

        int length = 0;
        int MaxOdd = 0;
        foreach (var kvp in data)
        {
            if (kvp.Value > MaxOdd && kvp.Value % 2 != 0)
            {
                length += MaxOdd / 2 * 2;
                MaxOdd = kvp.Value;
                continue;
            }
            length += kvp.Value / 2 * 2;
        }

        return length + MaxOdd;
    }
}