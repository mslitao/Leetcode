using System;
using System.Collections.Generic;
using System.Linq;

public class Solution132
{
    public int MinCut(string s) 
    {
        if(string.IsNullOrEmpty(s)) return 0;
        IList<IList<string>> results = new List<IList<string>>();
        

        int len = s.Length;
        bool[,] dp = new bool[len, len];
        int[] cut = new int[len];

        for(int i =len-1; i >=0 ; --i)
        {
            cut[i] = len;
            for(int j =i; j < len; ++j)
            {
                if(s[i] == s[j] && (j <= i +1 || dp[i+1, j-1]))
                {
                    dp[i, j] = true;
                    cut[i] = (j == len - 1) ? 0 : Math.Min(cut[i], cut[j + 1] + 1);
                }
            }
        }
        
        

        return cut[0];
    }
}