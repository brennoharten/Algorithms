using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Algorithm.EasyProblems
{
    public class PalindromeProblem
    {
        public static bool IsPalindrome(string s)
        {
            var clean = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            int start = 0;
            int end = clean.Length -1;
            while (start < end) {
                if (clean[start] != clean[end]) return false;
                
                start ++;
                end --;
            }
            return true;
        }
    }
}