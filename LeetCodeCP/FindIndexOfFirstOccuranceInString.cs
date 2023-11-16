using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCP
{
    public class FindIndexOfFirstOccuranceInString
    {
        public static int IndexOfFirstOccurance(string haystack, string needle)
        {
            for(int i = 0; i < haystack.Length - needle.Length + 1; i++)
            {
                if (haystack[i] == needle[0])
                {
                    bool found = true;
                    for(int j = 0 ; j<needle.Length; j++)
                    {
                        if (haystack[i+j] != needle[j])
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found) return i;
                }
            }
            return -1;
        }

        public int AnotherSolution(string haystack, string needle)
        {
            int index = haystack.IndexOf(needle);
            if(index == -1) return -1;
            return index;
        }

        public int OneOtherSolution(string haystack, string needle)
        {
            for(int i=0; i<haystack.Length - needle.Length + 1; i++)
            {
                if(haystack.Substring(i, needle.Length) == needle)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
