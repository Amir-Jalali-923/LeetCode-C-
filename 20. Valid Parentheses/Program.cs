// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.IsValid("(){}[]"));

public class Solution
{
    public static bool IsValid(string str)
    {
        Dictionary<char, char> matches = new Dictionary<char, char>
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };
        Stack<char> stk = new Stack<char>();
        char[] opens = new char[] { '(', '{', '[' };
        foreach (char c in str)
        {
            if (opens.Contains(c))
                stk.Push(c);
            else
            {
                if (stk.Count == 0 || c != matches[stk.Pop()])
                    return false;
            }
        }
        return stk.Count == 0 ? true : false;
    }
}
