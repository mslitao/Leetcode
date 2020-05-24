using System;
using System.Collections.Generic;
using System.Linq;

public class Solution5417
{
    public int MaxVowels(string s, int k) {
        HashSet<char> csets = new HashSet<char>(){'a','e', 'i','o','u'};

        int start = 0;
        Dictionary<char, int> map =new Dictionary<char, int>();
        int end = 0;
        int len = 0;
        while(end < s.Length)
        {
            if(!csets.Contains(s[end]))
            {
                start++;
                end++;
                map.Clear();
                continue;
            }

            if(!map.ContainsKey(s[end]))
                map.Add(s[end], 1);
            else
                map[s[end]] ++;

            while(end - start  + 1 > k)
            {
                map[s[start]] --;
                if(map[s[start]] == 0) map.Remove(s[start]);

                start ++;
            }

            if(end - start + 1 == k)
            {
                if(map.Count > len) len = map.Count;

                if(len == 5) return 5;
            }

            end ++;
        }

        return len;
    }
}