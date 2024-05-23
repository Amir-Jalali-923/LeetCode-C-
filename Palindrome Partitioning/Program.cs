using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{

    static void Main(string[] args)
    {
        IList<IList<string>> res = Partition("aab");
        foreach (var item in res)
        {
            foreach (var a in item)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n____________\n");
        }
        Console.ReadKey();

    }
    public static IList<IList<string>> Partition(string s)
    {
        IList<IList<string>> parts = new List<IList<string>>();
        Backtrack(s, 0, new List<string>(), parts);
        return parts;
    }

    private static void Backtrack(string s, int start, List<string> currentPartition, IList<IList<string>> partitions)
    {
        if (start == s.Length)
        {
            partitions.Add(new List<string>(currentPartition));
            return;
        }

        for (int i = start; i < s.Length; i++)
        {
            if (IsPalindrome(s, start, i))
            {
                currentPartition.Add(s.Substring(start, i - start + 1));
                Backtrack(s, i + 1, currentPartition, partitions);
                currentPartition.RemoveAt(currentPartition.Count - 1);
            }
        }
    }

    private static bool IsPalindrome(string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
                return false;
            left++;
            right--;
        }
        return true;
    }
}
