using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5 {
    public string LongestPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return string.Empty;
        }

        HashSet<Tuple<int, int>> sourceList = new HashSet<Tuple<int, int>>();
        Tuple<int, int> target = Tuple.Create(0, 0);
        for (int i = 0; i < s.Length; ++i)
        {
            sourceList.Add(Tuple.Create(i, i));

            if (i + 1 < s.Length && s[i] == s[i + 1])
            {
                sourceList.Add(Tuple.Create(i, i + 1));
            }
        }


        var newList = new HashSet<Tuple<int, int>>();
        foreach (var source in sourceList)
        {
            int i = source.Item1 - 1;
            int j = source.Item2 + 1;

            var match = Tuple.Create(0, 0);
            while (i >= 0 && j < s.Length && s[i] == s[j])
            {
                match = Tuple.Create(i, j);

                i = i - 1;
                j = j + 1;
            }

            if (match.Item2 != match.Item1)
            {
                newList.Add(match);

                if (match.Item2 - match.Item1 > target.Item2 - target.Item1)
                {
                    target = match;
                }
            }
            else if (source.Item2 - source.Item1 > target.Item2 - target.Item1)
            {
                target = source;
            }
        }

        return s.Substring(target.Item1, target.Item2 - target.Item1 + 1);
    }
    
    // Use DP
    public string LongestPalindrome_DP(string s)
    {
        if(string.IsNullOrEmpty(s)) return s;
        int len = s.Length;
        bool[,] dp = new bool[len, len];
        string result = string.Empty;
        
        for(int i =len-1; i >=0 ; --i)
            for(int j =i; j < len; ++j)
            {
                if(s[i] == s[j] && (j <= i +1 || dp[i+1, j-1]))
                {
                    dp[i, j] = true;

                    if(j - i + 1 > result.Length)
                        result = s.Substring(i, j - i + 1);
                }
            }
            
        return result;
    }

    // Method of recursive function
    public string LongestPalindrome_Recursive(string s)
    {
        if(string.IsNullOrEmpty(s) || s.Length <2) return s;
        int start = 0;
        int maxLen = 0;
        for(int i =0; i < s.Length - 1; ++i)
        {
            SearchPalindrome(s, i, i, ref start, ref maxLen);
            SearchPalindrome(s, i, i + 1, ref start, ref maxLen);
        }

        return s.Substring(start, maxLen);
    }
    public void SearchPalindrome(string s, int left, int right, ref int start, ref int maxLen)
    {
        while(left >=0 && right < s.Length && s[left] == s[right])
        {
            left --;
            right ++;
        }

        if(right - left - 1 > maxLen)
        {
            start = left + 1;
            maxLen = right - left - 1;
        }
    }
}