
namespace LeetCodeCP
{
    public class IsSubsequence
    {
        public static bool IsSubsequenceSolution(string s, string t)
        {
            int sIndex = 0;
            int tIndex = 0;
            while(sIndex < s.Length && tIndex<t.Length) {
                if (s[sIndex] == t[tIndex])
                {
                    sIndex++;
                }
                tIndex++;
            }
            return sIndex == s.Length;
        }
    }
}
