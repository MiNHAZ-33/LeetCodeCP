using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class MajorityElement
    {
        public static int MajorityElementSolution(int[] nums)
        {
            Dictionary<int, int> datas = new();
            for(int i = 0; i<nums.Length; i++)
            {
                datas[nums[i]] = datas.ContainsKey(nums[i]) ? datas[nums[i]] + 1 : 1;
            }
            return datas.FirstOrDefault(x => x.Value == datas.Values.Max()).Key;
        }
    }
}
