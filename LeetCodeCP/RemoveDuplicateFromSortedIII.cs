using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class RemoveDuplicateFromSortedIII
    {
        public static int RemoveDuplicate(int[] nums)
        {
            int i = 0;
            int limit = 0;
            for(int j = 1; j<nums.Length; j++)
            {
                if (nums[i] != nums[j])
                {
                    i++;
                    nums[i] = nums[j];
                    limit = 0;
                } else if (nums[i] == nums[j] && limit< 1)
                {
                    i++;
                    nums[i] = nums[j];
                    limit++;
                }
            }

            foreach(var num in  nums)
            {
                Console.WriteLine(num);
            }

            return i + 1;
        }
    }
}
