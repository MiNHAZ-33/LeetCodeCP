using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            int min = int.MaxValue;
            for(int i = 0; i<prices.Length; i++)
            {
                if (prices[i] < min)
                {
                    min = prices[i];
                } else if (prices[i] - min > max)
                {
                    max = prices[i] - min;
                }
            }
            return max;
        }
    }
}
