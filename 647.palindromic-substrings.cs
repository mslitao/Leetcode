using System;
using System.Collections.Generic;
using System.Linq;

public class Solution647 {
    public int CountSubstrings(string s) {
        if(string.IsNullOrEmpty(s)) return 0;
            int len = s.Length;
            bool[,] dp = new bool[len, len];
            int result = 0;
            
            for(int i =len-1; i >=0 ; --i)
                for(int j =i; j < len; ++j)
                {
                    if(s[i] == s[j] && (j <= i +1 || dp[i+1, j-1]))
                    {
                        dp[i, j] = true;
                        result++;
                    }
                }
            
            return result;
    }
}