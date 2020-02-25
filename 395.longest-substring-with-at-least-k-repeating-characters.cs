using System;
using System.Collections.Generic;

public class Solution395
{
    public int LongestSubstring(string s, int k) 
    {
        int[] charAndCount = new int[256];
        foreach (char c in s) {
            charAndCount[c]++;
        }

        for (int i = 0; i < s.Length; i++) {
            if (charAndCount[s[i]] > 0 && charAndCount[s[i]] < k) {
                // this char is wrong, either left or right has longestSubstring
                int left = LongestSubstring(s.Substring(0, i), k);
                int right = LongestSubstring(s.Substring(i + 1), k);
                return Math.Max(left, right);
            }
        }

        return s.Length;
    }
}