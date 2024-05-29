Console.WriteLine(Solution.RemoveElement(new int[] {3, 2, 2, 3}, 3));

public class Solution
{
    public static int RemoveElement(int[] nums, int val)
    {
        // Edge case: If the array has only one element which is not equal to val
        if (nums.Length == 1 && nums[0] != val)
            return 1;

        int i = 0; // Pointer starting from the beginning
        int j = nums.Length - 1; // Pointer starting from the end

        while (i < j)
        {
            // Move i to the right until nums[i] equals val
            while (i < nums.Length && nums[i] != val)
                i++;

            // Move j to the left until nums[j] is not equal to val
            while (nums[j] == val && i < j)
                j--;

            // If pointers have crossed, break the loop
            if (i >= j)
                break;

            // Swap elements at i and j
            int tmp = nums[j];
            nums[j] = nums[i];
            nums[i] = tmp;
        }

        // Return the new length of the array excluding the elements equal to val
        return i;
    }
}