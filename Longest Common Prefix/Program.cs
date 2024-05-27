// See https://aka.ms/new-console-template for more information
Console.WriteLine(Solution.LongestCommonPrefix(new string[]{"flower", "flow", "flight"}));
public class Solution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        int index = 0;
        string CP = "";
        while (index < strs[0].Length)
        {
            foreach (string str in strs)
                if (str.Length == index || str[index] != strs[0][index])
                    return CP;
            CP += strs[0][index];
            index++;
        }
        return CP;
    }
}