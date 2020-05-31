using System;
using System.Collections.Generic;
using System.Linq;

public class Solution1465
{
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        int mh = GetMaxPart(h, horizontalCuts);
        int mw = GetMaxPart(w, verticalCuts);

        int MOD = (int)1E9 + 7;

        long result =(long)mh*(long)mw;
        return (int)(result % MOD);
    }

    public int GetMaxPart(int size, int[] cuts)
    {
        List<int> allCuts = new List<int>();
        allCuts.Add(0);
        allCuts.Add(size);
        foreach(var hc in cuts)
        {
            if(hc != 0 && hc != size)
                allCuts.Add(hc);
        }
        allCuts.Sort();
        
        int max = 0;
        for(int i = 1; i < allCuts.Count; ++i)
        {
            max = Math.Max(max, allCuts[i] - allCuts[i -1]);
        }

        return max;
    }
}