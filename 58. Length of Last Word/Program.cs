Console.WriteLine(Solution.LengthOfLastWord("Hello world"));

public class Solution
{
    public static int LengthOfLastWord(string s)
    {
        bool foundLetter = false;
        int wordEnd = -1;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ' && foundLetter)
                return wordEnd - i;
            else if (s[i] != ' ' && !foundLetter)
            {
                foundLetter = true;
                wordEnd = i;
            }
        }
        return wordEnd == -1 ? 0 : wordEnd + 1;
    }
}