System.Console.WriteLine(Solution.AddBinary("11", "1"));

public class Solution
{
    public static string AddBinary(string a, string b)
    {
        if (a.Length > b.Length)
        {
            string tmp = a;
            a = b;
            b = tmp;
        }
        a = a.PadLeft(b.Length, '0');

        string sum = "";
        int c = 0;
        int j = a.Length - 1;
        for (int i = b.Length - 1; i >= 0; i--)
        {
            sum = (((a[j] ^ b[i]) & 1) ^ c) + sum;
            c = (((a[j] ^ b[i]) & c) | (a[j] & b[i]) & 1);
            j--;
        }

        if (c == 1)
            sum = 1 + sum;
        return sum;
    }
}