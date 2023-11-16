using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCodeCP
{
    public class RomanToInteger
    {
        // XCIVI

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romans = new Dictionary<char, int>()
                {
                    {'I', 1},
                    {'V', 5},
                    {'X', 10},
                    {'L', 50},
                    {'C', 100},
                    {'D', 500},
                    {'M', 1000}
                };
            int result = 0;
            for (int i=0; i<s.Length; i++)
            {
                int current = romans[s[i]];
                int next = i + 1 < s.Length ? romans[s[i + 1]] : 0;
                result += current < next ? -current : current;
            }

            return result;
        }
    }
}
