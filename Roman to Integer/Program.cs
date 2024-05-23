Console.WriteLine();
public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<char, int> table = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5},
                {'X', 10},
                {'L', 50 },
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
        int sum = 0;
        int last = table[s[0]];
        foreach (char c in s)
        {
            if (table[c] > last)
                sum = sum - last + table[c] - last;
            else
                sum += table[c];
            last = table[c];
        }
        return sum;
    }
}
