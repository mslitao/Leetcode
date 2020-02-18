using System;
using System.Collections.Generic;
using System.Linq;

public class Solution139
{
    public bool WordBreak(string s, IList<string> wordDict) {
        // This should be a DP problem
        int len = s.Length;
        int size = wordDict.Count;
        if(len == 0) return true;
        if(size ==0) return false;
        bool[] dp = new bool[len + 1];
        dp[0] = true;

        for(int i = 1; i <= len; ++i)
        {
            foreach( var word in wordDict)
            {
                var lastC = word.Last();
                var wordLen = word.Length;
                if(lastC == s[i -1] &&  wordLen <= i && s.Substring(i - wordLen, wordLen) == word && dp[i - wordLen])
                {
                    dp[i] = true;
                    break;
                }
            }
        }

        return dp[len];
    }
}