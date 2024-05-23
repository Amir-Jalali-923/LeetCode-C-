using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMid
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = Enumerable.Concat(nums1, nums2).ToArray();
            Array.Sort(nums);
            if (nums.Length % 2 == 0)
                return (nums[nums.Length / 2 - 1] + nums[nums.Length / 2 - 1 + 1]) / 2.0;
            else
                return nums[nums.Length / 2];
        }
    }
}
