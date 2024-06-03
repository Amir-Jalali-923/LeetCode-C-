System.Console.WriteLine(Solution.AppendCharacters("abcd","a"));

public class Solution
{
    public static int AppendCharacters(string s, string t)
    {
        int j = 0;
        for (int i = 0; i < s.Length && j < t.Length; i++)
        {
            if (s[i] == t[j])
                j++;
        }
        return t.Length - j;
    }
}