using System;
using System.Collections.Generic;
using System.Linq;

public class Solution264
{
    public int NthUglyNumber(int n) 
    {
        int i2 =0;
        int i3 = 0;
        int i5 = 0;

        List<int> results = new List<int>();
        results.Add(1);
        
        while(results.Count < n)
        {
            int n2 = results[i2] *2;
            int n3 = results[i3] *3;
            int n5 = results[i5] *5;

            int s = Math.Min(n2, Math.Min(n3, n5));
            if(s == n2) i2 ++;
            if(s == n3) i3 ++;
            if(s == n5) i5 ++;
            results.Add(s);
        }

        return results.Last();
    }
}