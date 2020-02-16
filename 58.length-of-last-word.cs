using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution58
{
    public int LengthOfLastWord(string s) {
        int lastLength = 0;
        int length = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == ' ')
            {
                length = 0;
            }
            else
            {
                length++;
                lastLength = length;
            }
        }

        return lastLength;
    }

    public int LengthOfLastWord2(string s) {
        return s.Trim().Split().LastOrDefault().Length;
    }
}