using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Solution1419
{
    public int MinNumberOfFrogs(string croakOfFrogs) {
        if(string.IsNullOrEmpty( croakOfFrogs)) return -1;

        int[] cnt = new int[5];
        int frogs = 0, max_frogs = 0;
        for (var i = 0; i < croakOfFrogs.Length; ++i) {
            var ch = croakOfFrogs[i];
            var n = "croak".IndexOf(ch);
            ++cnt[n];
            if (n == 0)
                max_frogs = Math.Max(max_frogs, ++frogs);
            else if (--cnt[n - 1] < 0)
                return -1;
            else if (n == 4)
                --frogs;
        }
        return frogs == 0 ? max_frogs : -1;  
    }
}