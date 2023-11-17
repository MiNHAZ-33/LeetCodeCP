using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class PlusOne
    {
        public static int[] PlusOneSol(int[] nums)
        {
            int i = nums.Length - 1;

            while (i >= 0)
            {
                if (nums[i] != 9)
                {
                    nums[i] = nums[i] + 1;
                    return nums;
                } else
                {
                    nums[i] = 0;
                    i--;
                }
            }
            int[] res = new int[nums.Length + 1];
            res[0] = 1;
            return res;
        }
        
    }
}
