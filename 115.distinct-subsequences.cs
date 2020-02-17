using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution115
{
    public int NumDistinct(string s, string t) 
    {
        if(s == null && t == null) return 1;
        if(s == null) return 0;
        if(t == null) return 1;

        int m = s.Length;
        int n = t.Length;

        int[,] dp = new int[m+1, n+1];

        for(int i =1; i <= n; ++i)
        {
            dp[0, i] = 0;
        }
        for(int i =0; i <= m; ++i)
        {
            dp[i, 0] = 1;
        }

        for(int i = 1; i <= m; ++i)
            for(int j = 1; j <= n; ++j)
            {
                dp[i, j] = dp[i-1, j] ;

                if(s[i-1] == t[j-1])
                {
                    dp[i,j]  += dp[ i-1, j-1];
                }

            }
        
        return dp[m,n];
    }
}