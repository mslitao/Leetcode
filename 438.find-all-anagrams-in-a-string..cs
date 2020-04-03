using System;
using System.Collections.Generic;
using System.Linq;

public class Solution438 
{
    public IList<int> FindAnagrams_2ndTry(string s, string p) {
        List<int> results = new List<int>();
        Dictionary<char, int> pMap = new Dictionary<char, int>();
        foreach(var c in p)
        {
            if(!pMap.ContainsKey(c))
            {
                pMap.Add(c, 1);
            }
            else
            {
                pMap[c]++;
            }
        }

        Dictionary<char, int> sMap = new Dictionary<char, int>();
        foreach(var item in pMap)
        {
            sMap.Add(item.Key, 0);
        }
        int left = 0;
        int right = 0;
        int size = p.Length;
        while(right < s.Length)
        {
            if(sMap.ContainsKey(s[right]) && ++sMap[s[right]] <= pMap[s[right]])
            {
                size --;
            }
            right ++;
            if(right - left > p.Length)
            {
                if(sMap.ContainsKey(s[left]) && --sMap[s[left]] < pMap[s[left]])
                {
                    size ++;
                }
                left ++;
            }

            if(size == 0)
            {
                results.Add(left);
            }
        }

        return  results;
    }

    // using sliding window, every time, just move once.
    public IList<int> FindAnagrams(string s, string p) 
    {
        IList<int> results = new List<int>();
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(p) || s.Length < p.Length) return results;

        Dictionary<char, int> pMap = new Dictionary<char, int>();
        foreach (var c in p)
        {
            if(!pMap.ContainsKey(c))
            {
                pMap.Add(c, 0);
            }
            pMap[c] = pMap[c] + 1;
        }

        int size = p.Length;
        //sliding window
        int left = 0;
        int right = 0;
        while(right< s.Length)
        {
            // Everytime, must move right once
            if(pMap.ContainsKey(s[right++]) && pMap[s[right - 1]] -- > 0) size --;
            // Check condition
            if(size ==0) results.Add(left);
            // Move left only when righ-left is a target size window
            if (right - left == p.Length && pMap.ContainsKey(s[left++])&& pMap[s[left-1]]++ >= 0) ++size;
        }

        return results;
    }

}