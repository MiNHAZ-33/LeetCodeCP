using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n) {
            int i = m - 1;
            int j = n - 1;
            int k = m + n - 1;

            while (i>= 0 && j >= 0)
            {
                if (nums1[i] > nums2[j])
                {
                    nums1[k--] = nums1[i--];
                 
                }
                else
                {
                    nums1[k--] = nums2[j--];
                  
                }
              
            }
            while(j>= 0)
            {
                
                nums1[k--] = nums2[j--];
               
            }

                      //print nums1
            for(int x = 0; x <m + n; x++)
            {
                Console.WriteLine(nums1[x]);
            }

        }
    }
}
