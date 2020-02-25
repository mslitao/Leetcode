using System;
using System.Collections.Generic;
using System.Linq;

public class Solution481 
{
    public int MagicalString(int n)
    {
        List<int> data = new List<int>();
        var cnt = 0;
        data.Add(1);
        var idx = 0;
        var slowIdx = 0;
        var slowCnt = data[slowIdx];
        while (idx < n)
        {
            var a = data[idx];

            
            if (a == 1)
            {
                cnt++;
            }

            if (slowCnt == 2)
            {
                data.Add(a);
            }
            else
            {
                data.Add(2 / a);
            }
            slowCnt--;
            if (slowCnt == 0)
            {
                slowIdx++;
                slowCnt = data[slowIdx];
            }

            idx++;
        }
        return cnt;
    }
}