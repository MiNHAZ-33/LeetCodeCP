using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class RemoveDuplicateFromSortedArray
    {
        public static int RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0) return 0;
            int i = 0;
            for(int j = 1; j<nums.Length; j++)
            {
                if (nums[j] != nums[i] )
                {
                    i++;
                    nums[i] = nums[j];
                }

            }
            return i + 1;
        }
    }
}
