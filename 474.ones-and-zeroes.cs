using System;
using System.Collections.Generic;
using System.Linq;

public class Solution474
{
    public int FindMaxForm(string[] strs, int m, int n) {
        if(strs == null || strs.Length ==0 || m< 0 || n < 0) return 0;

        //dp
        int[,] dp = new int[m+1, n+1];
        foreach(var str in strs)
        {
            var cnt0 = str.Count(x => x=='0');
            var cnt1 = str.Count(x => x=='1');
            for(int i =m; i >= cnt0; --i)
                for(int j = n; j >= cnt1; --j)
                {
                    var cnt = 0;
                    if(i >= cnt0 && j>= cnt1)
                    {
                        cnt = 1 + dp[i - cnt0, j - cnt1];
                    }
                    dp[i, j] = Math.Max(dp[i, j], cnt);
                }
        }
        
        return dp[m,n];
    }
}