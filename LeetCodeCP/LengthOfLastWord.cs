using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class LengthOfLastWord
    {
        public static int LengthOfTheLastWord(string s)
        {
            int count = 0;
            int last = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if (s[i] != ' ')
                {
                    count++;
                    last = count;
                } 
                else
                {
                    count = 0;
                }
            }
            return last;
        }
    }
}
