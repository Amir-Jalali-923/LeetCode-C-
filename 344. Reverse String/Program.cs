Solution.ReverseString("Hello World".ToCharArray());
public class Solution
{
    public static void ReverseString(char[] s)
    {
        int L = 0;
        int R = s.Length - 1;
        char tmp;
        while (L < R)
        {
            tmp = s[L];
            s[L++] = s[R];
            s[R--] = tmp;
        }
    }
}