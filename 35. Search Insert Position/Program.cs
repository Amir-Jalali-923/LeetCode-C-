System.Console.WriteLine(Solution.SearchInsert(new int[] { 1, 3, 5, 6 }, 7));
public class Solution
{
    public static int SearchInsert(int[] nums, int target)
    {
        int L = 0; int R = nums.Length; int mid;
        while (L < R)
        {
            mid = (R + L) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] > target)
                R = mid - 1;
            else
                L = mid + 1;
        }
        return L < nums.Length && nums[L] < target ? L + 1 : L;
    }
}