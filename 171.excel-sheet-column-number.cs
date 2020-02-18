using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution171
{
    public int TitleToNumber(string s) {
        int num = 0;
        for(int i = 0; i < s.Length; ++i)
        {
            num = num* 26 + s[i] - 'A' + 1;
        }

        return num;
    }
}