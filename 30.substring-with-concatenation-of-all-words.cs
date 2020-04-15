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

        for(int i = 0; i < k; ++i)
        {
            int start = i;
            int end = i;
            
            int matched = 0;
            Dictionary<string, int> map = new Dictionary<string, int>();
            while(end + k <= s.Length)
            {
                var str = s.Substring(end, k);
                if(!wordMap.ContainsKey(str)) 
                {
                    map.Clear();
                    start = end + k;
                    end = start;
                    matched = 0;
                    continue;
                }
                
                if(!map.ContainsKey(str)) map.Add(str, 1);
                else map[str] ++;
                if(map[str] <= wordMap[str]) matched ++;

                if(((end - start) / k + 1) > n)
                {
                    str =s.Substring(start, k); 
                    map[str] --;
                    start += k;

                    if(map[str] < wordMap[str]) matched --;
                }

                if(matched == n) results.Add(start);
                end += k;
            }
        }

        return results;
    }
}