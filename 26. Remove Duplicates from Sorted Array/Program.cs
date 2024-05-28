public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int max = nums.Max();
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] >= nums[i])
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] > nums[i - 1])
                    {
                        nums[i] = nums[j];
                        break;
                    }
                }
            }
            if (nums[i] == max)
            {
                return nums[i - 1] == nums[i] ? i : i + 1;
            }
        }
        return 1;
    }
}