using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class SearchInsertPosition
    {
        public static int SearchPosition(int[] nums, int target)
        {
            int mid;
            int left = 0;
            int right = nums.Length;
            while (left <= right )
            {
                mid = (left + right)/2;
                if (nums[mid] == target) return mid;
                if (nums[mid] > target)
                {
                    right = mid - 1;
                } else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
