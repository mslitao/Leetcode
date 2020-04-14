using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution30
{
    public IList<int> FindSubstring(string s, string[] words) {
        IList<int> results = new List<int>();
        if(string.IsNullOrEmpty(s) || words == null || words.Length == 0) return results;

        Dictionary<string, int> wordMap = new Dictionary<string, int>();
        int n = words.Length;
        int k = words[0].Length; 
        if(k== 0) return results;
        foreach(var w in words)
        {
            if(!wordMap.ContainsKey(w))
            {
                wordMap.Add(w, 1);
            }
            else
            {
                wordMap[w] ++;
            }
        }

        for(int i = 0; i < s.Length; ++i)
        {
            int cnt = 0;
            Dictionary<string, int> map = new Dictionary<string, int>();
            for(int j = 0; j < n; ++j)
            {
                if(i + j*k >= s.Length || i + j*k + k > s.Length) break;

                var str = s.Substring(i + j * k, k);
                if(!wordMap.ContainsKey(str)) break;
                if(!map.ContainsKey(str))
                {
                    map.Add(str, 1);
                }
                else
                {
                    map[str] ++;
                }

                if(map[str] > wordMap[str]) break;

                cnt ++;
            }
            
            if(cnt == n) 
            {
                results.Add(i);
            }
        }

        return results;
    }
}